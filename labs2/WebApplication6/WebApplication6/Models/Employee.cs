using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        [Display(Name ="Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public bool Active { get; set; }
    }
}
