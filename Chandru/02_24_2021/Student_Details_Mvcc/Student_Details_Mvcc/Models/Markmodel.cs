using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student_Details_Mvcc.Models
{
    [Table("tblMark")]
    public class Markmodel
    {
  
        [Key]
        public int Id { get; set; }

        [Display(Name ="Tamil")]
       
        public int Mark1 { get; set; }

        [Display(Name = "English")]
      
        public int Mark2 { get; set; }
        [Display(Name = "Maths")]
      
        public int Mark3 { get; set; }

        [Display(Name = "Science")]
      
        public int Mark4 { get; set; }

        [Display(Name = "SocialScience")]

      
        public int Mark5 { get; set; }
       
      
        public int Total { get; set; }

        public int? StdId { get; set; }
        [ForeignKey("StdId")]

        public Studentmodel Std_Name { get; set; }

       

       
    }
}