using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
        IEnumerable<Person> GetAll();
        
        Person GetPerson(int id);

        public IEnumerable<Person> FindPersonByCondition(System.Linq.Expressions.Expression<Func<Person, bool>> expression);
    }
}
