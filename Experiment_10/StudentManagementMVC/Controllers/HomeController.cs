using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StudentManagementMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Home page accessed");
            return View();
        }
    }
}