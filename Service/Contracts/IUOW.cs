using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface IUOW : IDisposable
    {
        IPersonRepository Person { get; }
        ILawSuitRepository LawSuit { get; }
        // ISystemUserRepository SystemUser { get; }
        IDictionaryRepository LawSuitDictionary { get; }

        void Commit();
    }
}
