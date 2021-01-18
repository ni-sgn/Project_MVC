using System;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTOs.SystemUser
{
    public class LoginDTO
    {
        [Required]
        [UIHint("email")]
        public string Email { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }
    }
}
