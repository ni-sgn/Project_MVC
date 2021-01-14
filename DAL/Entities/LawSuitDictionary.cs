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

        public ICollection<LawSuit> Statuses { get; set; }
    }
}
