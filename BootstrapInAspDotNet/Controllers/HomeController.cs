using BootstrapInAspDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapInAspDotNet.Controllers
{
    public class HomeController : Controller
    {
        private List<Employee> listEmployees = new List<Employee>();
        public HomeController() {
            listEmployees = new List<Employee> {
            new Employee() {Id=101,Name="abhi",Department="MECHANICAL",Age=25,Gender="male"},
             new Employee() {Id=102,Name="vinu",Department="CHEMICAL",Age=28,Gender="male"},
              new Employee() {Id=103,Name="shailu",Department="CHEMICAL",Age=25,Gender="male"}
        };
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
