using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalId { get; set; }

        public string CompanyName { get; set; }
        public string CompanyId { get; set; }

        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public int TypeId { get; set; }

        public ICollection<LawSuit> LawSuits { get; set; }
        public PersonType Type { get; set; }
        
    }
}
