using BLL.DTOs.LawSuit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawSuits.Models
{
    public class LawSuitListVM
    {
        public IEnumerable<LawSuitListDTO> LawSuits { get; set; }
    }
}
