using EGreetings_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EGreetings_Project.Data
{
    public class EGreetingsDbContext : IdentityDbContext<User>
    {
        public EGreetingsDbContext(DbContextOptions options) : base(options)
        {
        }

        //// Add the DbSet for Category
        public DbSet<Category> Categories { get; set; }
        //// DbSet cho Subscribes
        public DbSet<Subscribes> Subscriptions { get; set; }
        // DbSet cho Template
        public DbSet<Template> Templates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Ensure the table names follow the correct naming convention for Identity tables
            foreach (var et in builder.Model.GetEntityTypes())
            {
                var tableName = et.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    et.SetTableName(tableName.Substring(6));
                }
            }

            // Define primary key for Category table
            builder.Entity<Category>()
                .HasKey(c => c.CategoryId); // Define the primary key

            // Set default value for CreatedDate if not provided
            builder.Entity<Category>()
                .Property(c => c.CreatedDate)
                .HasDefaultValueSql("GETDATE()"); // Default value for CreatedDate, if you want a timestamp

            // Ensure that GroupCate is treated as a string
            builder.Entity<Category>()
                .Property(c => c.GroupCate)
                .HasMaxLength(10);  // Max length for the GroupCate string column, adjust as needed

            // Sub
            builder.Entity<Subscribes>()
               .HasKey(s => s.SubscriptionID);

            builder.Entity<Subscribes>()
                .Property(s => s.Price)
                .HasColumnType("float");

            builder.Entity<Subscribes>()
                .Property(s => s.isActive)
                .HasDefaultValue(true);

            //Template
            builder.Entity<Template>()
               .HasOne(t => t.Category)
               .WithMany()  // Có thể là một Category có nhiều Template
               .HasForeignKey(t => t.CategoryID)
               .OnDelete(DeleteBehavior.Restrict);
            // Đảm bảo rằng CreatedDate có giá trị mặc định
            builder.Entity<Template>()
                .Property(t => t.CreatedDate)
                .HasDefaultValueSql("GETDATE()");

            // Cấu hình các thuộc tính Price và Discount sử dụng float
            builder.Entity<Template>()
                .Property(t => t.Price)
                .HasColumnType("float");

            builder.Entity<Template>()
                .Property(t => t.Discount)
                .HasColumnType("float");

            // Cấu hình các thuộc tính khác nếu cần
            builder.Entity<Template>()
                .Property(t => t.Status)
                .HasDefaultValue(true);
        }

        public List<Category> GetAllCategories()
        {
            return Categories.ToList();  // Returns all categories
        }

        public List<Category> GetCategoriesByGroupCate(string groupCate)
        {
            return Categories
                    .Where(c => c.GroupCate == groupCate)
                    .ToList();  // Returns categories that match the specified GroupCate
        }
    }
}
