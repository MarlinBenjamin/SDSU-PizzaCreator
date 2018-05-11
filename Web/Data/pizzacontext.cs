using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Model;

namespace Web.Data
{
    public class pizzacontext : DbContext
    {
        public pizzacontext(DbContextOptions<pizzacontext> options) : base(options)
        {
        }
            public DbSet<CustomOrders> customOrders { get; set; }
            public DbSet<Shape> shapes { get; set; }
            public DbSet<Sauces> sauces { get; set; }
            public DbSet<Topping> toppings { get; set; }
            public DbSet<Customers> customers { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomOrders>().ToTable("CustomOrders");
            modelBuilder.Entity<Shape>().ToTable("Shapes");
            modelBuilder.Entity<Customers>().ToTable("Customers");
            modelBuilder.Entity<Topping>().ToTable("Toppings");
            modelBuilder.Entity<Sauces>().ToTable("Sauces");
            modelBuilder.Entity<Address>().ToTable("Address");
        }
        
    }
}
