using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Service.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(DatabaseContext context)
            : base(context)
        {

        }

        public IEnumerable<Person> GetAll()
        {
            return Context.People.Include(x => x.Type).Include(x => x.City);
        }

        public Person GetPerson(int id)
        {
            return Context.People.Where(x => x.Id == id).Include(x => x.Numbers).FirstOrDefault();
        }

        public IEnumerable<Person> FindPersonByCondition(System.Linq.Expressions.Expression<Func<Person, bool>> expression)
        {
            return Context.People.Where(expression).Include(x => x.Type).Include(x => x.City);
        }
    }
}
