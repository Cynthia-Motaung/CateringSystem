// CateringSystem/Data/DbSeeder.cs

using CateringSystem.Constants;
using CateringSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace CateringSystem.Data
{
    public static class DbSeeder
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            // Get the required services
            var userManager = service.GetService<UserManager<ApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();

            // Seed Roles
            if (!await roleManager.RoleExistsAsync(AppRoles.Admin))
            {
                await roleManager.CreateAsync(new IdentityRole(AppRoles.Admin));
            }
            if (!await roleManager.RoleExistsAsync(AppRoles.Employee))
            {
                await roleManager.CreateAsync(new IdentityRole(AppRoles.Employee));
            }

            // Define admin user details
            string adminEmail = "admin@cateringsystem.com";
            string adminPassword = "AdminPassword123!"; // Use a strong password in a real app!

            // Check if admin user exists
            if (await userManager.FindByEmailAsync(adminEmail) == null)
            {
                // Create the admin user
                var user = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true // You can set this to true
                };

                var result = await userManager.CreateAsync(user, adminPassword);

                // Assign the 'Admin' role
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, AppRoles.Admin);
                }
            }
        }
    }
}