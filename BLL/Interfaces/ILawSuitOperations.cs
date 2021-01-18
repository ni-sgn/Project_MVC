using BLL.DTOs.LawSuit;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface ILawSuitOperations
    {
        public IEnumerable<LawSuitListDTO> GetAll();
        public LawSuitCUComponents GetLawSuitCUComponents();
        public void CreateLawSuit(LawSuitCUDTO model);
        public LawSuitCUDTO GetLawSuit(int Id);
        public void UpdateLawSuit(LawSuitCUDTO lawsuit);
        public void DeleteLawSuit(int Id);
        public IEnumerable<LawSuitListDTO> GetByStatusType(string StatusType);
    }
}
