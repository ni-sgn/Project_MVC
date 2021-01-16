using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Person
{
    public class PhoneNumberDTO
    {
        public int Id { get; set; }
        
        public string Number { get; set; }

        public int TypeId { get; set; }
    }
}
