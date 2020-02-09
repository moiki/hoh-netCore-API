using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using hohsys.API.data;
using hohsys.API.dtos;
using hohsys.API.helpers;
using hohsys.API.models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace hohsys.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManageController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IManageRepo manageRepo;
        public ManageController(IManageRepo _manageRepo, IMapper _mapper)
        {
            manageRepo = _manageRepo;
            mapper = _mapper;
        }

        [HttpGet("MyProfile")]
        public async Task<IActionResult> MyProfile()
        {
            try
            {
                var result = await manageRepo.GetUser();
                var currenData = mapper.Map<UserForDetailsDto>(result);
                return Ok(new { Data = currenData });
            }
            catch (System.Exception e)
            {
                return BadRequest(new { code = 403, message = e.Message, InnerEx = e.InnerException.Message });
            }
        }

        [HttpGet("GetUsers")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUsers()
        {
            try
            {
                var result = await manageRepo.GetAllUsers();
                var currenData = mapper.Map<List<UserForDetailsDto>>(result);
                return Ok(new { Data = currenData });
            }
            catch (System.Exception e)
            {
                return BadRequest(new { code = 403, message = e.Message, InnerEx = e.InnerException, source = e.Source });
            }
        }

        [HttpPut("UpdateProfile")]
        public IActionResult updateProfile(UserForDetailsDto model){
            try
            {
                return Ok();
            }
            catch (System.Exception e)
            {
                return BadRequest(new { code = 403, message = e.Message, InnerEx = e.InnerException, source = e.Source });

            }
        }
    }
}