using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class LawSuitDictionary
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool HasStatus { get; set; }
        public bool HasCity { get; set; }
        public bool HasPhoneType { get; set; }
        public bool HasPersonType { get; set; }

        public ICollection<LawSuit> LawSuits { get; set; }
        public ICollection<Person> PersonCities { get; set; }
        public ICollection<Person>  PersonTypes { get; set; }
        public ICollection<PhoneNumber> Numbers { get; set; }
    }
}
