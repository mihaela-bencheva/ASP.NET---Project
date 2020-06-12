using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hopTropOnlineShop.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.EntityFrameworkCore;

namespace hopTropOnlineShop.DAL
{
    public class OnlineShopContext : DbContext
    {
        public OnlineShopContext(DbContextOptions<OnlineShopContext> options) : base(options)
        {
        }

        public DbSet<Cloth> Clothes { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<WishListCloth> WishListClothes { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cloth>().ToTable("Cloth");  
            modelBuilder.Entity<Basket>().ToTable("Basket");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Delivery>().ToTable("Delivery");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<WishListCloth>().ToTable("WishListCloth");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}

