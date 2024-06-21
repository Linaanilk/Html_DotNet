using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
      public IActionResult Index()
        { return View(); }
        public IActionResult Index2() { return View(); }
    }
}
