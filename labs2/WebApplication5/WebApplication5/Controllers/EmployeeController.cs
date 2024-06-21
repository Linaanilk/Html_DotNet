using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee=new Employee()
            {
                    Id=101,
                    FirstName="Mark",
                    LastName="Smith",
                    Email="mkjfds@gmail.com",
                    Active=true
            };
            return View(employee);
        }

        [HttpPost]
        public IActionResult Index(Employee employee)
        {
            return View(employee);
        }
    }
}
