using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View("Custom");
        }
        //public IActionResult Index3() 
        //{
        //    return View("Views\Custom\Custom.cshtml");
        //}
    }
}
