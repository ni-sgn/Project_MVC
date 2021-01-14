using DAL.Context;
using DAL.Entities;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(DatabaseContext context)
            : base(context)
        {

        }
    }
}
