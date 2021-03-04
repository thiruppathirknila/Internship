using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace RepositoryPattern.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Required Your Name") ]
        [StringLength (10,MinimumLength =4, ErrorMessage = "Name must be between 4 and 10 char") ]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required Your Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required Your Country")]

        public string Country { get; set; }
        [Required(ErrorMessage = "Required Your State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Required Your City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Required Your Phone")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Invalid Phone Number.")]
        public string Phone { get; set; }
    }
}
