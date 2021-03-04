using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_API.Models;

namespace Project_API.Data
{
    public class Project_APIContext : DbContext
    {
        public Project_APIContext (DbContextOptions<Project_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Project_API.Models.Product> Product { get; set; }
    }
}
