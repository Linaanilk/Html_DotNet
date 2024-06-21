using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using System.Xml.Linq;

namespace WebApplication8.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string SubmitUsingFormCollection(IFormCollection formCollection)
        {
            string Name = formCollection["Name"];
            string Email = formCollection["Email"];
            string Gender = formCollection["Gender"];
            string City = formCollection["City"];
            // string interests = string.Join(", ", formCollection["Interests"]);
            string interests =  formCollection["Interests"];
            return $"\n Name: {Name}\n Email: {Email}\n Gender: {Gender}\n City: {City}\n Interests: {interests}\n";
        }
      

    }
}
