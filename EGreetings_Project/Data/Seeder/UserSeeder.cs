using EGreetings_Project.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace EGreetings_Project.Data.Seeder
{
    public class UserSeeder
    {
        public static async Task SeedUserAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Ensure roles exist
            await EnsureRolesExistAsync(roleManager);

            // Default avatar image paths
            var defaultAdminAvatarPath = "images/useravarta/default-admin.jpg";
            var defaultUserAvatarPath = "images/useravarta/default-user.jpg";

            // Check if admin exists
            var adminUser = await userManager.FindByEmailAsync("admin@example.com");
            if (adminUser == null)
            {
                // Create admin account if not exist
                adminUser = new User
                {
                    UserName = "Admin",
                    Email = "admin@example.com",
                    Gender = true,
                    Dob = new DateTime(1985, 5, 15),
                    isSubscribed = true,
                    SubscriptionDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    imgAvatar = defaultAdminAvatarPath // Assign default avatar to admin
                };

                var result = await userManager.CreateAsync(adminUser, "AdminPassword123");

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

            // Create other users
            await CreateUserWithAvatar(userManager, "user@example.com", "User1", defaultUserAvatarPath, "UserPassword123");
            await CreateUserWithAvatar(userManager, "user2@example.com", "User2", defaultUserAvatarPath, "UserPassword123");
            await CreateUserWithAvatar(userManager, "user3@example.com", "User3", defaultUserAvatarPath, "UserPassword123");
            await CreateUserWithAvatar(userManager, "user4@example.com", "User4", defaultUserAvatarPath, "UserPassword123");
        }

        private static async Task CreateUserWithAvatar(UserManager<User> userManager, string email, string username, string avatarPath, string password)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    UserName = username,
                    Email = email,
                    Gender = false,
                    Dob = new DateTime(1990, 7, 20),
                    isSubscribed = false,
                    SubscriptionDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                    imgAvatar = avatarPath // Assign default avatar to user
                };

                var result = await userManager.CreateAsync(user, password);

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "User");
                    Console.WriteLine($"{username} created successfully.");
                }
                else
                {
                    Console.WriteLine($"Failed to create {username}.");
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
