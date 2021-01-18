using AutoMapper;
using BLL.DTOs.Person;
using BLL.Interfaces;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Operations
{
    public class PersonOperations : IPersonOperations
    {

        // here we have not only queries, which are described in services
        // but also some logic which wrap those queries...

        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public PersonOperations(IUOW uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        // Turn DataBase schema into Business schema
        public IEnumerable<PersonListDTO> GetAll()
        {
            var people = _uow.Person.GetAll();
            return _mapper.Map<IEnumerable<PersonListDTO>>(people);
        }

        public PersonCUComponents GetPersonFormComponents()
        {
            var dictionaries = _uow.LawSuitDictionary.GetPersonFormComponents();
            PersonCUComponents model = new PersonCUComponents();
            model.Cities = dictionaries.Where(x => x.HasCity).Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).ToList();
            model.Types = dictionaries.Where(x => x.HasPersonType).Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).ToList();
            model.PhoneTypes = dictionaries.Where(x => x.HasPhoneType).Select(x => new SelectListItem() { Text = x.Name, Value = x.Id.ToString() }).ToList();

            return model;
        }

        public PersonCUDTO GetPerson(int id)
        {
            var person = _uow.Person.GetPerson(id);
            return _mapper.Map<PersonCUDTO>(person);
        }

        public void CreatePerson(PersonCUDTO model)
        {
            var person = _mapper.Map<Person>(model);
            _uow.Person.Create(person);
            _uow.Commit();
        }

        public void UpdatePerson(PersonCUDTO model)
        {
            var dbPerson = _uow.Person.GetPerson(model.Id);
            _mapper.Map<PersonCUDTO, Person>(model, dbPerson);
            _uow.Person.Update(dbPerson);
            _uow.Commit();
        }

        public void DeletePerson(int id)
        {
            var dbPerson = _uow.Person.GetPerson(id);
            _uow.Person.Delete(dbPerson);
            _uow.Commit();
        }
    }
}
