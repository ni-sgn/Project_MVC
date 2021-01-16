using BLL.DTOs.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawSuits.Models
{
    public class PersonListVM
    {
        public IEnumerable<PersonListDTO> People { get; set; }
    }
}
