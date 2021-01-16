using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class SystemUser
    {
        public int Id { get; set; }
        public string PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public int TypeId { get; set; }
        public int PositionId { get; set; }

        // If we want to create a relation to another Table(Entity) we have to create the object of that type in this Entity
        // But, why are we creating two relation between the same Entities????
        public SystemDictionary Type { get; set; }
        public SystemDictionary Position { get; set; }
    }
}
