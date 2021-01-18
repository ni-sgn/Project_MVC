using BLL.DTOs.Person;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IPersonOperations
    {
        IEnumerable<PersonListDTO> GetAll();
        PersonCUComponents GetPersonFormComponents();
        void CreatePerson(PersonCUDTO model);
        PersonCUDTO GetPerson(int id);
        void UpdatePerson(PersonCUDTO model);
        void DeletePerson(int id);
    }
}
