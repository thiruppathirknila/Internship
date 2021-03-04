using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Mvcstudentdetails.Models
{
    [Table("tbl_studentdetails")]
    public class ModelStudent
    {
        [Key]
        public int Std_id { get; set; }
        [Required (ErrorMessage ="Name is requried")]
        public  string Name{ get; set; }

        [Required(ErrorMessage = "Gender is requried")]
        public string  Gender { get; set; }
        [Required(ErrorMessage = "Password is requried")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Address is requried")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Phone is requried")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is requried")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string  Email { get; set; }

        [Required(ErrorMessage = "Std_Class is requried")]
        public string Std_Class { get; set; }

        [Required(ErrorMessage = "Std_Sec is requried")]
        public string Std_Sec { get; set; }
    }
}