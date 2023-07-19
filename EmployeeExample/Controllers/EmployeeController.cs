using Microsoft.AspNetCore.Mvc;

namespace EmployeeExample.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
