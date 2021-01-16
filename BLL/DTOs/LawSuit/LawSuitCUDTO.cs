using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTOs.LawSuit
{
    public class LawSuitCUDTO
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreationDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ExpirationDate { get; set; }


        [Required(ErrorMessage = "Required")]
        public int PersonId { get; set; }

        [Required(ErrorMessage = "Required")]
        public int StatusId { get; set; }

    }
}
