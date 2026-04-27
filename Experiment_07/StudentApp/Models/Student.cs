using System.ComponentModel.DataAnnotations;

namespace StudentApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Range(18, 60)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}