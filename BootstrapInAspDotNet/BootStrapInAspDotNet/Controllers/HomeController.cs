using BootStrapInAspDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootStrapInAspDotNet.Controllers
{
    public class HomeController : Controller
    {
        // create a variable to store the list of Employees
        // this will be our Data Source
        private List<Employee> listEmployees = new List<Employee>();

        public HomeController()
        {
            listEmployees = new List<Employee>()
            {
                new Employee() {Id = 101, Name="John", Department="IT", Gender = "Male", Age = 42},
                new Employee() {Id = 102, Name="Kate", Department="Sales", Gender = "Female", Age = 42},
                new Employee() {Id = 103, Name="Micheal", Department="IT", Gender = "Male", Age = 42},
                new Employee() {Id = 104, Name="Anderson", Department="Finance", Gender = "Male", Age = 40},
                new Employee() {Id = 105, Name="William", Department="IT", Gender = "Male", Age = 42},
            };
        }
        public IActionResult Index()
        {
            return View(listEmployees);
        }

        public IActionResult Details(int Id)
        {
            //Employee employeeDetails = new Employee() { Id = Id, Name = "James", Department = "Marketing", Gender = "Male", Age = 42 };

            var employeeDetails = listEmployees.FirstOrDefault(empId => empId.Id == Id);

            // pass the employeeDetails to the View to make View Strongly Typed View
            return View(employeeDetails);
        }
    }
}
