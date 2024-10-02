using Ecommerce.Domain;
using ECOMMERCE.DOMAIN;
using Microsoft.EntityFrameworkCore;


namespace Ecommerce.infrastructure.Presistance
{
    public static class SeedingData
    {
        public static void SeedCategoryData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
             new Category {Id=1, Name = "cat1"  },
            new Category {Id=2, Name = "cat2" },
             new Category {Id=3, Name = "cat3" },
              new Category {Id=4, Name = "cat4" },
               new Category {Id=5, Name = "cat5" },
                new Category {Id=6, Name = "cat6" },
                 new Category { Id=7,Name = "cat7" },
                  new Category {Id=8, Name = "cat8" },
                   new Category {Id=9, Name = "cat9" });
            
        }

        public static void SeedUserData(this ModelBuilder modelBuilder) { 

            modelBuilder.Entity<User>().HasData(
                new User { Id=1, FirstName="mohamed", Email="mohamed@gmail.com",Password="11223"},
                new User { Id = 2, FirstName ="ali",Email="ali@outlook.com",Password="22344"},
                new User { Id = 3, FirstName = "ahmed", Email = "ahmed@outlook.com", Password = "22344" },
                new User { Id = 4, FirstName = "wael", Email = "wael@outlook.com", Password = "22344" },
                new User { Id = 5, FirstName = "ibrahim", Email = "ibrahim@outlook.com", Password = "22344" },
                new User { Id = 6, FirstName = "fouad", Email = "fouad@outlook.com", Password = "22344" },
                new User { Id = 7, FirstName = "mostafa", Email = "modtafa@outlook.com", Password = "22344" },
                new User { Id = 8, FirstName = "khedr", Email = "khedr@outlook.com", Password = "22344" },
                new User { Id = 9, FirstName = "hari", Email = "hari@outlook.com", Password = "22344" }

                );
        }
        public static void SeedOrderData(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, OrderDate = DateTime.Now, TotalAmoun = 4, UserId = 1 },
                new Order { Id = 2, OrderDate = DateTime.Now, TotalAmoun = 3, UserId = 8 },
                new Order { Id = 3, OrderDate = DateTime.Now, TotalAmoun = 9, UserId = 7 },
                new Order { Id = 4, OrderDate = DateTime.Now, TotalAmoun = 33, UserId = 7 },
                new Order { Id = 5, OrderDate = DateTime.Now, TotalAmoun = 14, UserId = 2 },
                new Order { Id = 6, OrderDate = DateTime.Now, TotalAmoun = 19, UserId = 3}

                );
        }
        public static void SeedProductData(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1,  Name= "dell", CategoryId = 1, Stock = 20,Description="electronics",Price=34500 },
              new Product { Id = 2, Name = "hp", CategoryId = 1, Stock = 14, Description = "electronics",Price = 34500 },
              new Product { Id = 3, Name = "lenovo", CategoryId = 1, Stock = 12, Description = "electronics",Price=3344 }
              
                );
        }
        public static void SeedImageData(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Image>().HasData(
                new Image { Id = 1, ProductId=2,Url="ghhjkj" }, new Image { Id = 2, ProductId = 2, Url = "ghhjkj" },
                 new Image { Id = 3, ProductId = 2, Url = "ghhjkj" }

                );
        }

        public static void SeedVisaData(this ModelBuilder modelBuilder)
        {
                

            modelBuilder.Entity<Visa>().HasData(
                new Visa { VisaId = 1, DateOfExpired = DateTime.UtcNow, HolderName ="oo HG" , UserId = 1 },
                 new Visa { VisaId = 2, DateOfExpired = DateTime.UtcNow, HolderName = "gg HG", UserId =2 },
                  new Visa { VisaId = 3, DateOfExpired = DateTime.UtcNow, HolderName = "kk HG", UserId =3 },
                  new Visa { VisaId = 4, DateOfExpired = DateTime.UtcNow, HolderName = "ll HG", UserId =1 },
                   new Visa { VisaId = 5, DateOfExpired = DateTime.UtcNow, HolderName = "uu HG", UserId = 5 }
                );
        }
    }
}
