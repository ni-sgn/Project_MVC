using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.LawSuit
{
    public class LawSuitListDTO
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public string Person { get; set; }
        public string Status { get; set; }
    }
}
