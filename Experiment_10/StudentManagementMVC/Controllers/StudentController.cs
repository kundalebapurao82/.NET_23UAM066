using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using StudentManagementMVC.Models;

namespace StudentManagementMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly IMemoryCache _cache;

        private static List<Student> students = new List<Student>();

        private const string CACHE_KEY = "student_list";

        public StudentController(ILogger<StudentController> logger, IMemoryCache cache)
        {
            _logger = logger;
            _cache = cache;
        }

        // VIEW STUDENTS (WITH CACHE)
        public IActionResult List()
        {
            _logger.LogInformation("Student List requested");

            if (!_cache.TryGetValue(CACHE_KEY, out List<Student> cachedStudents))
            {
                _logger.LogInformation("Cache miss - loading from source");

                cachedStudents = students;

                var cacheOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromMinutes(5));

                _cache.Set(CACHE_KEY, cachedStudents, cacheOptions);
            }
            else
            {
                _logger.LogInformation("Cache hit - data served from memory");
            }

            return View(cachedStudents);
        }

        // ADD STUDENT PAGE
        public IActionResult Add()
        {
            return View();
        }

        // POST ADD STUDENT
        [HttpPost]
        public IActionResult Add(Student s)
        {
            s.Id = students.Count + 1;
            students.Add(s);

            _logger.LogInformation($"Student added: {s.Name}");

            // Clear cache after update
            _cache.Remove(CACHE_KEY);

            return RedirectToAction("List");
        }
    }
}