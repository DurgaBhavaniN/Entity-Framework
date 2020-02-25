using System;
using System.Collections.Generic;
using EFProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EFProject.Context
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-79NDUF0\SQLEXPRESS;
                   Initial Catalog=EFProjectDB;User ID=sa;Password=pass@word1");
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
