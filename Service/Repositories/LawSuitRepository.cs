using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Contracts;
using System;
using System.Collections.Generic;
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
            return Context.LawSuits.Include(x=>x.Status).Include(x=>x.person);
        }
    }
}
