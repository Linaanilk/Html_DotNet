using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitForm(Employee employee) 
        {
            if(ModelState.IsValid) 
            {
                return View();
            }
            else
            {
                return View("Index" );
            }
        
        }
    }
}
