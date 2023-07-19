

using Microsoft.AspNetCore.Mvc;
using StronglyTypedViewsExample.Models;

namespace StronglyTypedViewsExample.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Index Page";
            ViewData["Header"] = "Employee Details";

            Employee employee = new Employee()
            {
                empId = 101,
                empName = "Kate Williamson",
                Department = "Sales",
                age = 30,
                Gender = "Female"
            };
            // strongly typed views for the employee model
            return View(employee);
        }
    }
}
