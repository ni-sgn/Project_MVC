using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Service.Repositories
{
    public class LawSuitRepository : RepositoryBase<LawSuit>, ILawSuitRepository
    {
        public LawSuitRepository(DatabaseContext context) : base(context)
        {
        }

        public IEnumerable<LawSuit> GetAll()
        {
            return Context.LawSuits.Include(x => x.Status).Include(x => x.person);
        }

        public LawSuit GetLawSuit(int Id)
        {
            //what does FirstOrDefault do here???
            return Context.LawSuits.Where(x => x.Id == Id).Include(x => x.person).FirstOrDefault();
        }

        public IEnumerable<LawSuit> GetByStatusType(Expression<Func<LawSuit, bool>> exp)
        {
            return Context.LawSuits.Where(exp).Include(x => x.Status).Include(x => x.person);
        }
    }
}
