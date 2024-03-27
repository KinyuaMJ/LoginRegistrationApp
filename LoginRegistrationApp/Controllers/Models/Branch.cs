using System.ComponentModel.DataAnnotations;

namespace LoginRegistrationApp.Controllers.Models
{
    public class Branch
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }



    }
}
