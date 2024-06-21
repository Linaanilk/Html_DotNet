using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1,FirstName="Mark",LastName="Antony",Gender="Male"},
                new Employee(){Id=2,FirstName="David",LastName="Beckam",Gender= "Male"},
                new Employee(){Id=3,FirstName="Marlie",LastName="Davis", Gender = "Female"},
            };
            return View(employees);
        }
    }
}
