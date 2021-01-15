using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface ILawSuitRepository : IRepositoryBase<LawSuit>
    {
        public IEnumerable<LawSuit> GetAll();
    }
}
