using Microsoft.EntityFrameworkCore;
using MySamurai2.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace MySamurai2.Data
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Server = (localdb)\\mssqllocaldb; Database = MySamurai2;");
        }
    }
}