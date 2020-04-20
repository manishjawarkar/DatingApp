using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; } 

        [Required]
        [StringLength(8, MinimumLength=3, ErrorMessage="Please provide your password")]
        public string Password { get; set; }
    }
}