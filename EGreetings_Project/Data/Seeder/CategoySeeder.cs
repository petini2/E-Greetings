using EGreetings_Project.Models;

namespace EGreetings_Project.Data.Seeder
{
    public class CategorySeeder
    {
        public static void Seed(EGreetingsDbContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            // Check if Categories are already seeded
            if (context.Categories.Any())
            {
                return; // Categories are already seeded
            }

            // Seed Categories
            var categories = new Category[]
            {
                new Category
                {
                    CategoryName = "First Birthday",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "BD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Teenager",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "BD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Adult",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "BD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Elder",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "BD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Animation",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "BD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Cute",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "BD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Funny",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "BD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Vintage",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "BD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Modern",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "BD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "General",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "BD",  // Changed to string
                    Status = true
                },
                // WD
                new Category
                {
                    CategoryName = "Vintage",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "WD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Indoor",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "WD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Outdoor",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "WD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "European Style",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "WD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Asian Style",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "WD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Modern",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "WD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Classic",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "WD",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "General",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "WD",  // Changed to string
                    Status = true
                },
                // LV
                new Category
                {
                    CategoryName = "New Year's Eve",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "NY",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Lunar New Year",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "NY",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Valentine Day",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "LV",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Qixi Festival",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "LV",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Mother's Day",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "LV",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Father's Day",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "LV",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Anniversary",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "LV",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Thank You",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "LV",  // Changed to string
                    Status = true
                },
                // FE
                new Category
                {
                    CategoryName = "Thanksgiving",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Merry Christmas",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Easter Day",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Mid Autumn Festival",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Mid Year Festival",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Halloween",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Music Festival",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Dance Festival",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Food Festival",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Flower Festival",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Single Day",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "FE",  // Changed to string
                    Status = true
                },
                // OT
                new Category
                {
                    CategoryName = "Women's Day",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "OT",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Vietnam Women's Day",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "OT",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Vietnam Teacher's Day",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "OT",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Children Day",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "OT",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Graduation",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "OT",  // Changed to string
                    Status = true
                },
                new Category
                {
                    CategoryName = "Party",
                    CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    GroupCate = "OT",  // Changed to string
                    Status = true
                },
            };

            context.Categories.AddRange(categories);

            // Save changes to the database
            context.SaveChanges();
        }
    }
}
