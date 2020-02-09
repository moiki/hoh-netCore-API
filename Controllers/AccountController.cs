using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using hohsys.API.data;
using hohsys.API.dtos;
using hohsys.API.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;

namespace hohsys.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private UserManager<User> userManager;
        private SignInManager<User> signInManager;
        private readonly IMapper mapper;
        private readonly IConfiguration config;
        public AccountController(UserManager<User> _userManager,
                                SignInManager<User> _signInManager,
                                IMapper _mapper,
                                IConfiguration _config)
        {
            mapper = _mapper;
            config = _config;
            userManager = _userManager;
            signInManager = _signInManager;
        }

        // Registration Endpoint
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<object> register(RegistrationUserDto model)
        {
            try
            {
                var appUser = mapper.Map<User>(model);
                appUser.IsActive = true;
                appUser.DateAdded = DateTimeOffset.UtcNow;
                appUser.DateUpdated = DateTimeOffset.UtcNow;
                // executing methods
                var result = await userManager.CreateAsync(appUser, model.password);
                return Ok(new { message = "Success", response = result, user = $"{model.name} {model.lastname}" });
            }
            catch (Exception e)
            {
                return BadRequest(new { code = 403, message = e.Message });
            }
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> login(LoginUserDto User)
        {
            try
            {
                var user = await userManager.FindByNameAsync(User.username);
                if (user == null) return Unauthorized(new {message = "User not found"});
                
                var result = await signInManager.CheckPasswordSignInAsync(user, User.password, false);

                // if checking password success
                if (result.Succeeded)
                {
                    var appUser = mapper.Map<UserForDetailsDto>(user);
                    var tokenR = await GenerateToken(user);
                    return Ok(new {token = tokenR, userLogged = appUser});
                }
                return Unauthorized();
            }
            catch (Exception e)
            {
                return BadRequest(new { code = 403, message = e.Message });
            }
        }

        private async Task<string> GenerateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName)
            };
            var roles = await userManager.GetRolesAsync(user);
            if (roles != null)
            {
                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role));
                }
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}