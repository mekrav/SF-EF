using Microsoft.EntityFrameworkCore;
using Mod25.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mod25
{
    public class AppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        public AppDBContext() : base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-HFRSFTT\SQLEXPRESS;Database=EF;Trusted_Connection=True;");
        }
    }
}