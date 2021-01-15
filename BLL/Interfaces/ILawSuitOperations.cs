using BLL.DTOs.LawSuit;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface ILawSuitOperations
    {
        public IEnumerable<LawSuitListDTO> GetAll();
    }
}
