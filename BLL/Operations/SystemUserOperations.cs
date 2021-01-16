using AutoMapper;
using BLL.DTOs.SystemUser;
using BLL.Interfaces;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Operations
{
    public class SystemUserOperations : ISystemUserOperations
    {
        private readonly IMapper _mapper;
        private readonly IUOW _iuow;

        public SystemUserOperations(IMapper mapper, IUOW iuow)
        {
            _mapper = mapper;
            _iuow = iuow;
        }

        public IEnumerable<SystemUserListDTO> GetAll()
        {
            var Users = _iuow.SystemUser.GetAll();
            return _mapper.Map<IEnumerable<SystemUserListDTO>>(Users);
        }
    }
}
