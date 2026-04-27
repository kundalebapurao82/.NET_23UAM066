using Microsoft.AspNetCore.Mvc;
using StudentEFApp.Data;
using StudentEFApp.Models;
using System.Linq;

namespace StudentEFApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewStudents()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("ViewStudents");
            }
            return View(student);
        }

        public IActionResult Edit(int id)
        {
            var student = _context.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return RedirectToAction("ViewStudents");
            }
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction("ViewStudents");
        }
    }
}