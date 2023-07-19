using Microsoft.AspNetCore.Mvc;

using controller.Models;

namespace ControllersInAspDotNet.Controllers
{
    public class HomeController :Controller
    {
        [Route("/")]
        public string Index() 
        {
            return "My first ASP .NET MVC application";
        }
        [Route("home")]
        public string Home()
        {
            return "My first ASP .NET MVC Home Page";
        }
        [Route("contents")]
        public IActionResult ShowContent()
        {
            //return new ContentResult()
            //{
            //    Content = "Show the Content of this Method",ContentType = "text/html"
            //};
            return Content("<h1>show the content of this method</h1>","text/html");
        }
        //[Route("employee")]
        //public JsonResult EmployeeDetails()
        //{
        //    Employee employee = new Employee()
        //    {
        //        Id = 1,
        //        Name = "Joo",
        //        Description = "male",
        //        Title = "mr",
        //        Address = "usa",
        //        Age = 30
        //    };
        //    return Json(employee);
        //}

        [Route("employee")]
        public IActionResult EmployeeDetails()
        {
            Employee employee = new Employee()
            {
                Id = 1,Name="Joo",Description="male",Title="mr",Address="usa",Age=30
            };
            return Json(employee);
        }
    }
}
