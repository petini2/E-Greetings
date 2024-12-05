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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var et in builder.Model.GetEntityTypes())
            {
                var tableName = et.GetTableName();
                if (tableName.StartsWith("AspNet"))
                {
                    et.SetTableName(tableName.Substring(6));
                }
            }
        }
    }
}
