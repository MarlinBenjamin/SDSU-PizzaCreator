using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Web.Data
{
    public class signupcontext : DbContext
    {
        public signupcontext(DbContextOptions<signupcontext> options) : base(options)
        {
        }
        public DbSet<CustomFirstN> customFirstN { get; set; }
        public DbSet<CustomLastN> customLastN { get; set; }
        public DbSet<CustomEmail> customEmail { get; set; }
        public DbSet<CustomDateOfBirth> customDateOfBirth { get; set; }
        public DbSet<CustomAddress> customAddress { get; set; }
        public DbSet<CustomCountry> customCountry { get; set; }
        public DbSet<CustomCity> customCity { get; set; }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomFirstN>().ToTable("First Name");
        modelBuilder.Entity<CustomLastN>().ToTable("Last Name");
        modelBuilder.Entity<CustomEmail>().ToTable("Email");
        modelBuilder.Entity<CustomDateOfBirth>().ToTable("Date of Birth");
        modelBuilder.Entity<CustomAddress>().ToTable("Address");
        modelBuilder.Entity<CustomCountry>().ToTable("Country");
        modelBuilder.Entity<CustomCity>().ToTable("City");
    }
}
