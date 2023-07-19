using Microsoft.AspNetCore.Mvc;
using ViewBagExample.Models;

namespace ViewBagExample.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Index page";
            ViewBag.Header = " Employee Details";
            Employee employee = new Employee()
            { 
                EmployeeId = 1,
                Age = 30,
                Name = "Test",
                Gender="male",
                Department="IT"
            };
            ViewBag.Employee = employee;
            return View();
        }
    }
}
