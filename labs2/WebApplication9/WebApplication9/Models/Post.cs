using System.ComponentModel.DataAnnotations;

namespace WebApplication9.Models
{
    public class Post
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [CustomValidation]
        public string Message { get; set; }
    }
}
