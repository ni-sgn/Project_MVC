using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public int TypeId { get; set; }
        public int PersonId { get; set; }

        public LawSuitDictionary Type { get; set; }
        public Person person { get; set; }
    }
}
