using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class SystemUserRepository : RepositoryBase<SystemUser>, ISystemUserRepository
    {
        // DatabaseContext is basically a connection to the database server...
        public SystemUserRepository(DatabaseContext context) : base(context)
        {
        }

        public IEnumerable<SystemUser> GetAll()
        {
            return Context.SystemUsers.Include(e => e.Type).Include(e => e.Position);
        }
    }
}
