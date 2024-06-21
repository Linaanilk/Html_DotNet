using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please enter First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please enter Email")]
        public string Email { get; set; }

        [Range(18,30, ErrorMessage = "Age must be between 18 and 30")]
        [Required(ErrorMessage = "Please enter Age")]
        public int Age { get; set; }
    }
}
