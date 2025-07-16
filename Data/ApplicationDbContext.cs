// In Data/ApplicationDbContext.cs

using CateringSystem.Models; // Add this
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

// Change ApplicationUser to ApplicationUser here
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Add this DbSet for your new model
    public DbSet<EmployeeProfile> EmployeeProfiles { get; set; }
}