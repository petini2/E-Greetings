using EGreetings_Project.Models;
using Microsoft.AspNetCore.Identity;
using System.IO;

namespace EGreetings_Project.Data.Seeder
{
    public class UserSeeder
    {
        public static async Task SeedUserAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Ensure roles exist
            await EnsureRolesExistAsync(roleManager);

            // Create admin account
            var adminUser = await userManager.FindByEmailAsync("admin@example.com");
            if (adminUser == null)
            {
                adminUser = new User
                {
                    UserName = "Admin",
                    Email = "admin@example.com",
                    Gender = true,
                    Dob = new DateTime(1985, 5, 15),
                    isSubscribed = true,
                    SubscriptionDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Image = "/images/user/default-admin.jpg" // Hình ảnh mặc định cho admin
                };

                var result = await userManager.CreateAsync(adminUser, "AdminPassword123"); // Đảm bảo mật khẩu được chỉ định
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                    Console.WriteLine("Admin user created successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create admin user.");
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine($"Error: {error.Description}");
                    }
                }
            }

            // Create regular users (user1, user2, user3, etc.)
            await CreateUserWithImageAsync(userManager, "user@example.com", "User1", "/images/user/default-user.jpg", "UserPassword123");
            await CreateUserWithImageAsync(userManager, "user2@example.com", "User2", "/images/user/default-user.jpg", "UserPassword123");
            await CreateUserWithImageAsync(userManager, "user3@example.com", "User3", "/images/user/default-user.jpg", "UserPassword123");
            await CreateUserWithImageAsync(userManager, "user4@example.com", "User4", "/images/user/default-user.jpg", "UserPassword123");
        }

        private static async Task CreateUserWithImageAsync(UserManager<User> userManager, string email, string userName, string imagePath, string password)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    UserName = userName,
                    Email = email,
                    Gender = false,
                    Dob = new DateTime(1990, 7, 20),
                    isSubscribed = false,
                    SubscriptionDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    Image = imagePath // Thêm đường dẫn hình ảnh
                };

                var result = await userManager.CreateAsync(user, password); // Đảm bảo mật khẩu được chỉ định
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "User");
                    Console.WriteLine($"{userName} created successfully.");
                }
                else
                {
                    Console.WriteLine($"Failed to create {userName}.");
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine($"Error: {error.Description}");
                    }
                }
            }
        }

        private static async Task EnsureRolesExistAsync(RoleManager<IdentityRole> roleManager)
        {
            // Create "Admin" role if it doesn't exist
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            // Create "User" role if it doesn't exist
            var userRole = await roleManager.FindByNameAsync("User");
            if (userRole == null)
            {
                await roleManager.CreateAsync(new IdentityRole("User"));
            }
        }
    }
}
