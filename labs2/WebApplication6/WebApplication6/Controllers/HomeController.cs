using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index() 
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
