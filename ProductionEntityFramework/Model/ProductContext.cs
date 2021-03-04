using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductionEntityFramework
{
    class ProductContext : DbContext
    {
        public DbSet<Product>MyProducts
        { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Produktverwaltung;Integrated Security=True");
        }
    }

    
}
