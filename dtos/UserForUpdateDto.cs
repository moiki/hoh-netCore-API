using System.ComponentModel.DataAnnotations;

namespace hohsys.API.dtos
{
    public class UserForUpdateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Profession { get; set; }
        public string ProfilePicture { get; set; }
        [Required]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "This email address is not valid.")]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}