using Microsoft.AspNetCore.Mvc;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SubmitForm(Post post)
        {
            if(ModelState.IsValid) 
            {
            
            return View();
            
            }
            return View("Index");
        }
    }
}
