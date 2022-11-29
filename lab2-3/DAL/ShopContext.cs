using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

using lab2_3.Models;

namespace lab2_3.DAL
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Recycle> Recycles { get; set; }
        public ShopContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=3004;Host=127.0.0.1;Port=5432;Database=labaTP;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product { ID = 1, Name = "Пиво", Price = 100 },
                    new Product { ID = 2, Name = "Виски", Price = 500 },
                    new Product { ID = 3, Name = "Коньяк", Price = 1000 }
            );
        }

    }
    
}
