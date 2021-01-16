using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface ISystemUserRepository : IRepositoryBase<SystemUser>
    {
        public IEnumerable<SystemUser> GetAll();
    }
}
