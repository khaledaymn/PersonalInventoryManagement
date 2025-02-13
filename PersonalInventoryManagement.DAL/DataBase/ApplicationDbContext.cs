using Microsoft.EntityFrameworkCore;
using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.DAL.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        #region DBSet

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonalInventoryManagement;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasIndex(u => u.UserName)
            .IsUnique();

          
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<Category>().HasData(
            //    new Category {Id = 100, Name = "Electronics", ImageURL = "Images/Categories/1.jpg" },
            //    new Category {Id = 101, Name = "Clothing", ImageURL = "Images/Categories/2.jpg" },
            //    new Category {Id = 102, Name = "Home Appliances", ImageURL = "Images/Categories/3.jpg" },
            //    new Category {Id = 103, Name = "Books", ImageURL = "Images/Categories/4.jpg" },
            //    new Category {Id = 104, Name = "Toys", ImageURL = "Images/Categories/5.jpg" },
            //    new Category {Id = 105, Name = "Sports", ImageURL = "Images/Categories/6.jpg" },
            //    new Category {Id = 106, Name = "Beauty & Health", ImageURL = "Images/Categories/7.jpg" },
            //    new Category {Id = 107, Name = "Furniture", ImageURL = "Images/Categories/8.jpg" }
            //);


            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 100, CategoryId = 100, ExpireDate = new DateTime(2028, 2, 10), ImageURL = "Images/Products/1.jpg", Name = "Laptop", Price = 1500.99m, Quantity = 3, UserId = 1 },
                new Product { Id = 101, CategoryId = 100, ExpireDate = new DateTime(2027, 2, 10), ImageURL = "Images/Products/2.jpg", Name = "Smartphone", Price = 799.99m, Quantity = 1, UserId = 1 },
                new Product { Id = 102, CategoryId = 101, ExpireDate = new DateTime(2026, 2, 10), ImageURL = "Images/Products/3.jpg", Name = "T-Shirt", Price = 19.99m, Quantity = 2, UserId = 1 },
                new Product { Id = 103, CategoryId = 101, ExpireDate = new DateTime(2026, 2, 10), ImageURL = "Images/Products/4.jpg", Name = "Jeans", Price = 39.99m, Quantity = 3, UserId = 1 },
                new Product { Id = 104, CategoryId = 102, ExpireDate = new DateTime(2030, 2, 10), ImageURL = "Images/Products/5.jpg", Name = "Washing Machine", Price = 499.99m, Quantity = 2, UserId = 1 },
                new Product { Id = 105, CategoryId = 102, ExpireDate = new DateTime(2032, 2, 10), ImageURL = "Images/Products/6.jpg", Name = "Refrigerator", Price = 899.99m, Quantity = 2, UserId = 1 },
                new Product { Id = 106, CategoryId = 103, ExpireDate = new DateTime(2035, 2, 10), ImageURL = "Images/Products/7.jpg", Name = "Fiction Novel", Price = 12.99m, Quantity = 1, UserId = 1 },
                new Product { Id = 107, CategoryId = 104, ExpireDate = new DateTime(2028, 2, 10), ImageURL = "Images/Products/8.jpg", Name = "Children's Toy Car", Price = 25.99m, Quantity = 3, UserId = 1 },
                new Product { Id = 108, CategoryId = 105, ExpireDate = new DateTime(2029, 2, 10), ImageURL = "Images/Products/9.jpg", Name = "Basketball", Price = 29.99m, Quantity = 2, UserId = 1 },
                new Product { Id = 109, CategoryId = 106, ExpireDate = new DateTime(2033, 2, 10), ImageURL = "Images/Products/10.jpg", Name = "Dumbbells Set", Price = 99.99m, Quantity = 1, UserId = 1 }
            );

            modelBuilder.Entity<Product>().HasData(
  // ✅ منتجات غير منتهية الصلاحية (Good) 
  new Product { Id = 1000, CategoryId = 100, ExpireDate = new DateTime(2028, 12, 10), ImageURL = "Images/Products/1.jpg", Name = "Laptop", Price = 1500.99m, Quantity = 3, UserId = 1 },  // ✅ صالح لمدة طويلة
new Product { Id = 1010, CategoryId = 100, ExpireDate = new DateTime(2027, 7, 15), ImageURL = "Images/Products/2.jpg", Name = "Smartphone", Price = 799.99m, Quantity = 1, UserId = 1 },  // ✅ صالح لمدة طويلة
new Product { Id = 1020, CategoryId = 101, ExpireDate = new DateTime(2025, 9, 5), ImageURL = "Images/Products/3.jpg", Name = "T-Shirt", Price = 19.99m, Quantity = 2, UserId = 1 },  // 🟠 Expire Soon
new Product { Id = 1030, CategoryId = 101, ExpireDate = new DateTime(2026, 4, 20), ImageURL = "Images/Products/4.jpg", Name = "Jeans", Price = 39.99m, Quantity = 3, UserId = 1 },  // ✅ صالح لمدة طويلة
new Product { Id = 1040, CategoryId = 102, ExpireDate = new DateTime(2029, 11, 30), ImageURL = "Images/Products/5.jpg", Name = "Washing Machine", Price = 499.99m, Quantity = 2, UserId = 1 },  // ✅ صالح لمدة طويلة
new Product { Id = 1050, CategoryId = 102, ExpireDate = new DateTime(2030, 5, 18), ImageURL = "Images/Products/6.jpg", Name = "Refrigerator", Price = 899.99m, Quantity = 2, UserId = 1 },  // ✅ صالح لمدة طويلة

// 🟠 منتجات ستنتهي قريبًا (Expire Soon) - خلال 30 يوم
new Product { Id = 1060, CategoryId = 103, ExpireDate = new DateTime(2025, 2, 20), ImageURL = "Images/Products/7.jpg", Name = "Fiction Novel", Price = 12.99m, Quantity = 1, UserId = 1 },
new Product { Id = 1070, CategoryId = 104, ExpireDate = new DateTime(2025, 3, 1), ImageURL = "Images/Products/8.jpg", Name = "Children's Toy Car", Price = 25.99m, Quantity = 3, UserId = 1 },
new Product { Id = 1080, CategoryId = 105, ExpireDate = new DateTime(2025, 2, 15), ImageURL = "Images/Products/9.jpg", Name = "Basketball", Price = 29.99m, Quantity = 2, UserId = 1 },

// 🔴 منتجات منتهية الصلاحية (Expired) - قبل اليوم
new Product { Id = 1090, CategoryId = 106, ExpireDate = new DateTime(2024, 12, 1), ImageURL = "Images/Products/10.jpg", Name = "Dumbbells Set", Price = 99.99m, Quantity = 1, UserId = 1 },
new Product { Id = 1100, CategoryId = 101, ExpireDate = new DateTime(2025, 1, 10), ImageURL = "Images/Products/11.jpg", Name = "Running Shoes", Price = 49.99m, Quantity = 2, UserId = 1 },
new Product { Id = 1200, CategoryId = 103, ExpireDate = new DateTime(2025, 1, 25), ImageURL = "Images/Products/12.jpg", Name = "Winter Jacket", Price = 89.99m, Quantity = 3, UserId = 1 }
);



        }
    }
}
