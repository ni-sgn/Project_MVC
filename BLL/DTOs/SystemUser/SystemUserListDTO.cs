using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.SystemUser
{
    public class CreateUserDTO
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
