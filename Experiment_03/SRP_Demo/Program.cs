using System;

namespace SRP_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create student object
            Student student = new Student
            {
                Name = "Bapurao",
                Marks = 85
            };

            // Display student data
            StudentDisplay display = new StudentDisplay();
            display.Display(student);

            // Save student data
            StudentRepository repository = new StudentRepository();
            repository.Save(student);

            Console.ReadLine();
        }
    }
}