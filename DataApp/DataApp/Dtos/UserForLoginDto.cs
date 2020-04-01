using System.ComponentModel.DataAnnotations;

namespace DataApp.Controllers
{
    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }


    }
}