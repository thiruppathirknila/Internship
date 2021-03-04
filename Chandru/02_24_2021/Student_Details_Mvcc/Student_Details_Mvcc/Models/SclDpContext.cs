using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Student_Details_Mvcc.Models
{
    public class SclDpContext:DbContext
    {
        public DbSet<Studentmodel> Studentmodels { get; set; }
        public DbSet<Markmodel>Markmodels { get; set; }
        public DbSet<UserRegistration> userRegistrations { get; set; }

        
    }
}