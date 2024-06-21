using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User user = new User()
            {
                Id = 1,
                Name = "Haya",
                Email = "hay@gmail.com"
            };
            return View(user);
        }
    }
}
