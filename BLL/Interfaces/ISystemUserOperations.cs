using BLL.DTOs.SystemUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface ISystemUserOperations
    {
        public IEnumerable<SystemUserListDTO> GetAll();
    }
}
