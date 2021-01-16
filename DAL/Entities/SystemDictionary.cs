using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class SystemDictionary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasPosition { get; set; }
        public bool HasUserType { get; set; }
  

        public ICollection<SystemUser> UserPositions { get; set; }
        public ICollection<SystemUser> UserTypes { get; set; }

    }
}
