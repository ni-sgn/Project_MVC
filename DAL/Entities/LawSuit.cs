using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class LawSuit
    {

        public int Id { get; set; }

        public DateTime RegistrationDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public int PersonId { get; set; }
        public int StatusId { get; set; }

        public LawSuitDictionary Status { get; set; }
        public Person person { get; set; }

        //uflebamosili piri???
    }
}
