using Microsoft.EntityFrameworkCore;
using DataAnnotationTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationTask.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\NEWSQLSERVER; DataBase=dataAnnotation; Trusted_Connection=true; TrustServerCertificate=true;");
        }

    }
}
