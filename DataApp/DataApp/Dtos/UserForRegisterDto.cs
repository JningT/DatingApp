using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataApp.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(8,MinimumLength = 4,ErrorMessage ="You must specify password between 4 and 8")]
        public string  Username { get; set; }
        public string Password { get; set; }
    }
}
