using StudentAPI.Models;

namespace StudentAPI.Data
{
    public static class StudentData
    {
        public static List<Student> Students = new List<Student>
        {
            new Student { Id = 1, Name = "Bapurao", Age = 22, Email = "test@gmail.com" }
        };
    }
}