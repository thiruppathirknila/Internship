using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Student_Details_Mvcc.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Details_Mvcc.Models
{
    [Table("tblStudentDetails")]
    public class UserRegistration
    {
        [Key]
        public int    studentId { get; set; }
        [Required(ErrorMessage = "Required Your FirstName")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required Your LastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Required Your FatherName")]
        public string FatherName { get; set; }
        [Required(ErrorMessage = "Required Your Gender")]
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "DateOfBirth")]
        [Required(ErrorMessage = "Required Your DateOfBirth")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string DateOfBirth { get; set; }
        [Required(ErrorMessage = "Required Your MobileNumber")]
        public string MobNo { get; set; }

       
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Invalid E-Mail")]
        [Required(ErrorMessage = "Required Your Email")]
        public string Email { get; set; }
        [DataType("Password")]
        [Required(ErrorMessage = "Required Your Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Required Your Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Required Your State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Required Your City")]
        public string City { get; set; }
      
    }
}



