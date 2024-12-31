
using EGreetings.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EGreetings.Data
{
    public class EGreetingsDbContext : IdentityDbContext<User>
    {
        public EGreetingsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<UserSub> UserSubs { get; set; }
        public DbSet<PayInfor> PayInfors { get; set; }
        public DbSet<EGreetings.Models.Template> Templates { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<TemplateHistory> TemplateHistories { get; set; }


        public DbSet<Transaction> Transactions { get; set; }


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

            // Sub
            builder.Entity<Subscription>()
                .HasKey(s => s.SubscriptionID);

            builder.Entity<Subscription>()
                .Property(s => s.Price)
                .HasColumnType("float");

            builder.Entity<Subscription>()
                .Property(s => s.isActive)
                .HasDefaultValue(true);

            // UserSub
            // UserSub
            builder.Entity<UserSub>()
                .HasKey(us => us.UserSubID);

            builder.Entity<UserSub>()
                .HasOne(us => us.User)
                .WithMany(u => u.UserSubs)  // Đảm bảo 'User' có thuộc tính 'UserSubs'
                .HasForeignKey(us => us.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<UserSub>()
                .HasOne(us => us.Subscription)
                .WithMany(s => s.UserSubs)  // Đảm bảo 'Subscription' có thuộc tính 'UserSubs'
                .HasForeignKey(us => us.SubscriptionID)
                .OnDelete(DeleteBehavior.Cascade);

            // PayInfor
            builder.Entity<PayInfor>()
                .HasKey(p => p.PayID);

            builder.Entity<PayInfor>()
                .HasOne(p => p.User)
                .WithMany(u => u.PayInfors)  // Đảm bảo 'User' có thuộc tính 'PayInfors'
                .HasForeignKey(p => p.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            // Booking
            builder.Entity<Booking>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookings)  // Đảm bảo 'User' có thuộc tính 'Bookings'
                .HasForeignKey(b => b.UserID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Booking>()
                .HasOne(b => b.Template)
                .WithMany(t => t.Bookings)  // Đảm bảo 'Template' có thuộc tính 'Bookings'
                .HasForeignKey(b => b.TemplateID)
                .OnDelete(DeleteBehavior.Cascade);

            // Template
            builder.Entity<EGreetings.Models.Template>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Templates)  // Đảm bảo 'Category' có thuộc tính 'Templates'
                .HasForeignKey(t => t.CategoryID)
                .OnDelete(DeleteBehavior.Cascade);



            // Feedback
            builder.Entity<Feedback>()
                .HasOne(f => f.Booking)
                .WithOne(b => b.Feedback) // Điều hướng đến 'Feedback' trong lớp Booking
                .HasForeignKey<Feedback>(f => f.BookingID)
                .OnDelete(DeleteBehavior.Cascade);

            // Transaction
            builder.Entity<Transaction>()
                .HasOne(t => t.User)
                .WithMany(u => u.Transactions)
                .HasForeignKey(t => t.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Transaction>()
                .HasOne(t => t.Booking)
                .WithOne(b => b.Transaction)
                .HasForeignKey<Transaction>(t => t.BookingID)
                .OnDelete(DeleteBehavior.Cascade);

            // TemplateHistory
            builder.Entity<TemplateHistory>()
                .HasOne(th => th.Template)
                .WithMany(t => t.TemplateHistories)
                .HasForeignKey(th => th.TemplateID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<TemplateHistory>()
       .HasOne(th => th.Booking)
       .WithMany(b => b.TemplateHistories)  // Use WithMany for a one-to-many relationship
       .HasForeignKey(th => th.BookingID)
       .OnDelete(DeleteBehavior.Restrict);

            // BookingDetails
            builder.Entity<Booking>()
                .HasMany(b => b.BookingDetails)
                .WithOne(bd => bd.Booking)
                .HasForeignKey(bd => bd.BookingID)
                .OnDelete(DeleteBehavior.Cascade);
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
