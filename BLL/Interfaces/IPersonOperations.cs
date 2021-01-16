using BLL.DTOs.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IPersonOperations
    {
        public IEnumerable<PersonListDTO> GetAll();
        public PersonCUComponents GetPersonFormComponents();
        public void CreatePerson(PersonCUDTO model);
    }
}
