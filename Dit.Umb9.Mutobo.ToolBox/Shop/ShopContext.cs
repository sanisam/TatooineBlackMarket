using Dit.Umb9.Mutobo.ToolBox.Shop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dit.Umb9.Mutobo.ToolBox.Shop
{
    public class ShopContext : DbContext
    {

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
 

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basket>().ToTable("Baskets");
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<Product>().ToTable("Products");

        }
    }
}
