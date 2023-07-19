using Microsoft.AspNetCore.Mvc;

namespace SharedLayoutExample.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
