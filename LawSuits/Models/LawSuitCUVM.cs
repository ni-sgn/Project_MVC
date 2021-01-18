using BLL.DTOs.LawSuit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawSuits.Models
{
    public class LawSuitCUVM
    {
        public LawSuitCUDTO LawSuit { get; set; }
        public LawSuitCUComponents Components { get; set; }
    }
}
