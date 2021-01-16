using AutoMapper;
using BLL.DTOs.LawSuit;
using BLL.Interfaces;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Operations
{
    public class LawSuitOperations : ILawSuitOperations
    {
        private readonly IMapper _mapper;
        private readonly IUOW _uow;

        public LawSuitOperations(IMapper mapper, IUOW uow)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public IEnumerable<LawSuitListDTO> GetAll()
        {
            // Sql Query
            var LawSuits = _uow.LawSuit.GetAll();
            // transfer the result into business schemas
            return _mapper.Map<IEnumerable<LawSuitListDTO>>(LawSuits);
        }


    }
}
