// In Models/ApplicationUser.cs

using Microsoft.AspNetCore.Identity;

namespace CateringSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Navigation property to link to the EmployeeProfile
        public virtual EmployeeProfile? EmployeeProfile { get; set; }
    }
}