using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BLL.DTOs.Person
{
    public class PersonCUDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(maximumLength:50, MinimumLength =2, ErrorMessage = "min 2 and max 50 symbols")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(maximumLength: 50, MinimumLength = 2, ErrorMessage = "min 2 and max 50 symbols")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Required")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "must contain 11 characters")]
        [RegularExpression("^[0-9]*", ErrorMessage = "only numbers are possible")]
        public string PersonalId { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(maximumLength:50, MinimumLength = 2, ErrorMessage = "min 2 and max 50 symbols")]
        public string CompanyName { get; set; }


        [Required(ErrorMessage = "Required")]
        [StringLength(maximumLength: 11, MinimumLength = 11, ErrorMessage = "must contain 11 characters")]
        [RegularExpression("^[0-9]*", ErrorMessage = "only numbers are possible")]
        public string CompanyId { get; set; }

        [Required(ErrorMessage = "Required")]
        public int TypeId { get; set; }

        [Required(ErrorMessage = "Required")]
        public int CityId { get; set; }

        public IList<PhoneNumberDTO> Numbers { get; set; }

        //public ICollection<LawSuit> LawSuits { get; set; }
        //public ICollection<PhoneNumber> Numbers { get; set; }
        //public PersonType Type { get; set; }
        //public LawSuitDictionary City { get; set; }
    }
}
