using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee()
            {
                Id = 1,
                FirstName = "Kiara",
                LastName = "Dev",
                DateOfBirth = DateTime.Now,
                Active = true,
            };
            return View(employee);
        }
        public IActionResult Index2() 
        {
            Employee employee = new Employee()
            {
                Id = 1,
                FirstName = "Kiara",
                LastName = "Dev",
                DateOfBirth = DateTime.Now,
                Active = true,
            };
            return View(employee);
        }
        public IActionResult Index3() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index3(Employee employee)
        {
            return View();
        }
    }
}
