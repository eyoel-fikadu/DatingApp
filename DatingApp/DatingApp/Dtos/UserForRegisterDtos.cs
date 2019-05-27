using System.ComponentModel.DataAnnotations;

namespace DatingApp.Dtos
{
    public class UserForRegisterDtos
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8,MinimumLength = 4,ErrorMessage = "You Must specify password between 4 and 8 character")]
        public string Password { get; set; }
    }
}