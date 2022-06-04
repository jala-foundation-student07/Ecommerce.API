using System;
using Ecommerce.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.DAL
{
    public class EcomerceDbContext : DbContext
    {
        public EcomerceDbContext(DbContextOptions options) : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasData(new Product { Id = 1, FirstName = "Sugar", Description = "Sugar from the orient of Bolivia"});
            builder.Entity<Product>().HasData(new Product { Id = 2, FirstName = "Milk", Description = "Elaborated with the major effort" });
        }
    }
}
