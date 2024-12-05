using EGreetings_Project.Models;
using Microsoft.AspNetCore.Identity;

namespace EGreetings_Project.Data.Seeder
{
    public class UserSeeder
    {
        public static async Task SeedUserAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            // Ensure roles exist
            await EnsureRolesExistAsync(roleManager);

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

            var user = await userManager.FindByEmailAsync("user@example.com");

            if (user == null)
            {
                // Create regular user if not exist
                user = new User
                {
                    UserName = "User1",
                    Email = "user@example.com",
                    Gender = false,
                    Dob = new DateTime(1990, 7, 20),
                    isSubscribed = false,
                    SubscriptionDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                };

                var result = await userManager.CreateAsync(user, "UserPassword123");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "User"); // Corrected to assign role to user
                    Console.WriteLine("User created successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create user.");
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine($"Error: {error.Description}");
                    }
                }
            }

            // User 2

            var user2 = await userManager.FindByEmailAsync("user2@example.com");

            if (user2 == null)
            {
                // Create regular user if not exist
                user2 = new User
                {
                    UserName = "User2",
                    Email = "user2@example.com",
                    Gender = false,
                    Dob = new DateTime(1990, 7, 20),
                    isSubscribed = false,
                    SubscriptionDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                };

                var result = await userManager.CreateAsync(user2, "UserPassword123");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user2, "User"); // Corrected to assign role to user
                    Console.WriteLine("User created successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create user.");
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine($"Error: {error.Description}");
                    }
                }
            }


            // User 3

            var user3 = await userManager.FindByEmailAsync("user3@example.com");

            if (user3 == null)
            {
                // Create regular user if not exist
                user3 = new User
                {
                    UserName = "User3",
                    Email = "user3@example.com",
                    Gender = false,
                    Dob = new DateTime(1990, 7, 20),
                    isSubscribed = false,
                    SubscriptionDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                };

                var result = await userManager.CreateAsync(user3, "UserPassword123");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user3, "User"); // Corrected to assign role to user
                    Console.WriteLine("User created successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create user.");
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine($"Error: {error.Description}");
                    }
                }
            }
            // User 4

            var user4 = await userManager.FindByEmailAsync("user4@example.com");

            if (user4 == null)
            {
                // Create regular user if not exist
                user4 = new User
                {
                    UserName = "User4",
                    Email = "user4@example.com",
                    Gender = false,
                    Dob = new DateTime(1990, 7, 20),
                    isSubscribed = false,
                    SubscriptionDate = DateTime.Now,
                    CreatedDate = DateTime.Now,
                };

                var result = await userManager.CreateAsync(user4, "UserPassword123");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user4, "User"); // Corrected to assign role to user
                    Console.WriteLine("User created successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to create user.");
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
