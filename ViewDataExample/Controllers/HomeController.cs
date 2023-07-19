using Microsoft.AspNetCore.Mvc;
using ViewDataExample.Models;

namespace ViewDataExample.Controllers
{
    [Controller]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Details";

            Student student = new Student()
            {
                StudentAge = 30,
                StudentEmail = "john@gmail.com",
                StudentId = 1,
                StudentName = "John",
                Course="engg"
            };
            //viewData contains the Student data 
            ViewData["Student"] = student;


            return View();
        }

       
    }
}
