using System;

namespace SRP_Demo
{
    public class StudentDisplay
    {
        public void Display(Student student)
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine($"Name  : {student.Name}");
            Console.WriteLine($"Marks : {student.Marks}");
        }
    }
}