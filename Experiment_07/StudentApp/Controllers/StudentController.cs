using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>();

        // HOME
        public IActionResult Index()
        {
            return View();
        }

        // VIEW
        public IActionResult ViewStudents()
        {
            return View(students);
        }

        // ADD (GET)
        public IActionResult AddStudent()
        {
            return View();
        }

        // ADD (POST)
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = students.Count + 1;
                students.Add(student);
                return RedirectToAction("ViewStudents");
            }
            return View(student);
        }

        // EDIT (GET)
        public IActionResult Edit(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            return View(student);
        }

        // EDIT (POST)
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                var existing = students.FirstOrDefault(s => s.Id == student.Id);
                if (existing != null)
                {
                    existing.Name = student.Name;
                    existing.Age = student.Age;
                    existing.Email = student.Email;
                }
                return RedirectToAction("ViewStudents");
            }
            return View(student);
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                students.Remove(student);
            }
            return RedirectToAction("ViewStudents");
        }
    }
}