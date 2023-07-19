using Microsoft.AspNetCore.Mvc;
using SharedLayoutExample.Models;

namespace SharedLayoutExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Details";

            Student student = new Student()
            {
                StudentId = 101,
                Name = "John",
                Course = "PG-DAC",
                Age = 30
            };
            // ViewData contains the student data
            ViewData["Student"] = student;

            return View();
        }
       
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
