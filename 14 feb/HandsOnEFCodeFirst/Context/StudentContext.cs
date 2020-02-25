using System;
using System.Collections.Generic;
using System.Text;
using HandsOnEFCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
namespace HandsOnEFCodeFirst.Context
{
    class StudentContext:DbContext
    {
        //define entities
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Define connection string
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-79NDUF0\SQLEXPRESS;Initial Catalog=StudentDB;User ID=sa;Password=pass@word1");
        }
    }
}
