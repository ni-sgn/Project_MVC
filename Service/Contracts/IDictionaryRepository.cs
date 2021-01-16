using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface IDictionaryRepository : IRepositoryBase<LawSuitDictionary>
    {
        IEnumerable<LawSuitDictionary> GetPersonFormComponents();
    }
}
