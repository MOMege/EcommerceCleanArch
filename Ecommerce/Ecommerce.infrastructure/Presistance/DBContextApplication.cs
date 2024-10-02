using Ecommerce.Domain;
using ECOMMERCE.DOMAIN;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph.Contacts.Item.MemberOf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.infrastructure.Presistance
{
    public class DBContextApplication :DbContext
    {
        public DBContextApplication(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.SeedCategoryData();
            modelBuilder.SeedUserData();
            modelBuilder.SeedOrderData();
            modelBuilder.SeedVisaData();
            modelBuilder.SeedProductData();

            
            base.OnModelCreating(modelBuilder);

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=KAMAL\SQLEXPRESS;initial catalog=ShoppindDb;Integrated Security=True ;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //    base.OnConfiguring(optionsBuilder);
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
       
    }

