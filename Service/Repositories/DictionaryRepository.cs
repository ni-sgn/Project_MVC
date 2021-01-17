using DAL.Context;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Repositories
{
    public class DictionaryRepository : RepositoryBase<LawSuitDictionary>, IDictionaryRepository
    {
        public DictionaryRepository(DatabaseContext context)
            : base(context)
        {

        }

        public IEnumerable<LawSuitDictionary>  GetPersonFormComponents()
        {
            return FindByCondition(x => x.HasPersonType || x.HasCity || x.HasPhoneType);
        }
    }
}
