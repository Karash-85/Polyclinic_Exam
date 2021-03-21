using Microsoft.EntityFrameworkCore;
using Polyclinic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyclinic.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=polyclinicappdb;Trusted_Connection=True;");
        }
    }
}
