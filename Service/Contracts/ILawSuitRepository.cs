using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Service.Contracts
{
    public interface ILawSuitRepository : IRepositoryBase<LawSuit>
    {
        public IEnumerable<LawSuit> GetAll();
        public LawSuit GetLawSuit(int Id);
        public IEnumerable<LawSuit> GetByStatusType(Expression<Func<LawSuit, bool>> exp);
    }
}
