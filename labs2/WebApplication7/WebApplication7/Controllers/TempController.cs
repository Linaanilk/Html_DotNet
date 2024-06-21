using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Controllers
{
    public class TempController : Controller
    {
        //used to pass data between the controller action method
        //but 
        public IActionResult Index1()
        {
            TempData["Data"] = "Data from index1";
            return View();
        }
        public IActionResult Index2() 
        {
            //ViewBag.Data = TempData["Data"];
            //TempData.Keep("Data");

            ViewBag.Data = TempData.Peek("Data");
            return View();
        }
        public IActionResult Index3() 
        {
            ViewBag.Data = TempData["Data"];
            return View();
        }
    }
}
