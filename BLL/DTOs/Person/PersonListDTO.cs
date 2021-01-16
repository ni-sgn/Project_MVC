using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Person
{
    // Schemas for Business logic have 
    // slightly different properties
    // because they aren't used for queries anymore...
    // they are closer to the real world objects

    public class PersonListDTO
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalId { get; set; }

        public string CompanyName { get; set; }
        public string CompanyId { get; set; }

        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public string Type { get; set; }



    }
}
