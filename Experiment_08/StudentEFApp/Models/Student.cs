using System.ComponentModel.DataAnnotations;

namespace StudentEFApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = "";

        [Range(18, 60)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";
    }
}