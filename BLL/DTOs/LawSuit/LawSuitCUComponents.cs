using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.LawSuit
{
    public class LawSuitCUComponents
    {
        public List<SelectListItem> Statuses { get; set; }
        public List<SelectListItem> People { get; set; }
    }
}
