using Microsoft.AspNetCore.Mvc;

namespace controller.Controllers
{
    public class EmployeeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
