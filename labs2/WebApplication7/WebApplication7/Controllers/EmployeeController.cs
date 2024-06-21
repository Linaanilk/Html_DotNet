using Microsoft.AspNetCore.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string SubmitUsingParameter(string firstName,string lastName) 
        {
            return "firstName : " + firstName+ ", lastName: "+lastName;
        }

        [HttpPost]
        public string SubmitUsingFormCollection(IFormCollection formCollection)
        {
            string firstName = formCollection["firstName"];
            string lastName = formCollection["lastName"];
            return "firstName : " + firstName + ", lastName: " + lastName;
        }

        [HttpPost]
        public string SubmitUsingBinding(EmployeeModel employee)
        {
           
            return "firstName : " + employee.FirstName + ", lastName: " + employee.LastName;
        }
    }
}
