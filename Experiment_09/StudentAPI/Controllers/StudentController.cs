using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Data;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // 🔹 GET ALL
        [HttpGet]
        public ActionResult<List<Student>> GetAll()
        {
            return Ok(StudentData.Students);
        }

        // 🔹 GET BY ID
        [HttpGet("{id}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = StudentData.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            return Ok(student);
        }

        // 🔹 CREATE
        [HttpPost]
        public ActionResult AddStudent(Student student)
        {
            student.Id = StudentData.Students.Count + 1;
            StudentData.Students.Add(student);

            return Ok(student);
        }

        // 🔹 UPDATE
        [HttpPut("{id}")]
        public ActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = StudentData.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.Email = updatedStudent.Email;

            return Ok(student);
        }

        // 🔹 DELETE
        [HttpDelete("{id}")]
        public ActionResult DeleteStudent(int id)
        {
            var student = StudentData.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound("Student not found");

            StudentData.Students.Remove(student);

            return Ok("Deleted successfully");
        }
    }
}