using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistrationApp.Controllers.Models
{
    public class Employees
    {
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }

        public String DepartmentId { get; set; }

        [ForeignKey("Id")] //add departmentid to employee model
        public Department Department { get; set; }

        public string Role { get; set; }
        public DateTime CreationDate { get; set; }

        public String CreatedBy { get; set; } 

        public String BranchName { get; set; }

        public DateTime EffectiveStartDate { get; set; }

        public DateTime EffectiveEndDate { get; set; }

        public DateTime LastUpdated { get; set; }

        public AppUser AppUser { get; set; }

    }

}
