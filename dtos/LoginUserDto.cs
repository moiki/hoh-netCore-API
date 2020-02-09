using System.ComponentModel.DataAnnotations;

namespace hohsys.API.dtos
{
    public class LoginUserDto
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}