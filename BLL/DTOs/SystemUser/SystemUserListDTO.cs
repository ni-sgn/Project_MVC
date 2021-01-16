using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.SystemUser
{
    public class SystemUserListDTO
    {
        public int Id { get; set; }
        public string PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public string Type { get; set; }
        public string Position { get; set; }
    }
}
