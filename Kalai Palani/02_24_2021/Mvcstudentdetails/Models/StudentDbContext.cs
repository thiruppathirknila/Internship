using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Mvcstudentdetails.Models
{
    public class StudentDbContext:DbContext
    {
        public DbSet<ModelStudent> ModelStudents { get; set; }
    }
}