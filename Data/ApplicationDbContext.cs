using System;
using System.Collections.Generic;
using System.Text;
using CityProv.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CityProv.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<City>().Property(c => c.CityId).IsRequired();
            builder.Entity<Province>().Property(p => p.ProvinceCode).IsRequired();

            builder.Entity<City>().ToTable("City");
            builder.Entity<Province>().ToTable("Province");

            builder.Seed();
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
    }
}
