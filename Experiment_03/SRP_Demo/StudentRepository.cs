using System;

namespace SRP_Demo
{
    public class StudentRepository
    {
        public void Save(Student student)
        {
            Console.WriteLine("Saving student data...");
            Console.WriteLine("Student data saved successfully!");
        }
    }
}