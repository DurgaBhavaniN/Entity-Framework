using System;
using System.Collections.Generic;
using System.Text;
using EFDAL.Models;
using Microsoft.EntityFrameworkCore;
namespace EFDAL.Context
{
   public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-79NDUF0\SQLEXPRESS;Initial Catalog=EMSDB;User ID=sa;Password=pass@word1");

        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
