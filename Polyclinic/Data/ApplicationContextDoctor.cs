using Microsoft.EntityFrameworkCore;
using Polyclinic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyclinic.Data
{
    class ApplicationContextDoctor : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public ApplicationContextDoctor()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=polyclinicappdb;Trusted_Connection=True;");
        }
    }
}
