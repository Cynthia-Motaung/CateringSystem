// In Models/EmployeeProfile.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CateringSystem.Models
{
    public class EmployeeProfile
    {
        [Key]
        public int Id { get; set; } // Primary Key for the profile

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Position { get; set; }

        // Foreign Key to link to the ApplicationUser
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
    }
}