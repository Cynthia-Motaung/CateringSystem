using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CateringSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser> // Use IdentityUserContext if you have a custom user class, otherwise use IdentityUser directly
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
