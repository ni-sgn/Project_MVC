using BLL.DTOs.SystemUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LawSuits.Models
{
    public class SystemUserListVM
    {
        public IEnumerable<SystemUserListDTO> SystemUsers { get; set; }
    }
}
