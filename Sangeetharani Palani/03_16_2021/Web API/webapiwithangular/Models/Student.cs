using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webapiwithangular.Models
{
    [Table("StudentDetails")]
    public class Student
    {
        [Key]
        public int StuId { get; set; }
        public string StuName { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string Mobileno { get; set; }
    }
}
