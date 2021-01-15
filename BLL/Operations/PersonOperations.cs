using AutoMapper;
using BLL.DTOs.Person;
using BLL.Interfaces;
using Service.Contracts;
using System;
using System.Collections.Generic;
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
    }
}
