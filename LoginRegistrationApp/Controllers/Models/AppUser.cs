using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace LoginRegistrationApp.Controllers.Models
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
       
        public String Department { get; set; }

        /*[ForeignKey]
        public Department Department { get; set; }
*/
        public string Role {  get; set; }
        public DateTime CreationDate { get; set; }

        public String CreatedBy { get; set; }

        public String BranchName { get; set;}

        public DateTime EffectiveStartDate { get; set; }

        public DateTime EffectiveEndDate { get; set;}

        public DateTime LastUpdated {  get; set; }

    }
}
