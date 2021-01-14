using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contracts
{
    public interface IUOW : IDisposable
    {
        IPersonRepository Person { get; }

        void Commit();
    }
}
