using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Details_Mvcc.Models
{
    [Table("tblstudent")]
    public class Studentmodel
    {
        [Key]
        public int RoleNo { get; set; }
       
        [Display(Name = "Name")]
        public string Std_Name { get; set; }
        [Display(Name = "Gender")]
        
        public string Gender { get; set; }
        [Display(Name = "Class")]
        public string std_Class { get; set; }
        [Display(Name = "Section")]
        public string std_Section { get; set; }
        [Display(Name = "Active")]
        public bool IsActive { get; set; }
       
    }
}