using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Person
{
    public class PersonCUComponents
    {
        public List<SelectListItem> Types { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }


}
