using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult Index1() 
        {
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Jayan",
                Email = "jayan@gmail.com"
            };
            ViewBag.Employee = employee;
            return View(); 
        }   
        public IActionResult Index2() 
        {
            string name = "John";
           ViewBag.Name = name;

            ViewBag.List = new List<string>() { "Mark", "Paul", "John" };

            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Jayan",
                Email = "jayan@gmail.com"
            };
            ViewBag.Employee = employee;

            return View();        
        }
        public IActionResult Index3()
        {

            ViewBag.List = new List<Employee>
            {
                new Employee { Id = 1, Name = "Mark", Email = "mark@example.com" },
                new Employee { Id = 2, Name = "Paul", Email = "paul@example.com" },
                new Employee { Id = 3, Name = "John", Email = "john@example.com" }
            };


            return View();
        }
        public IActionResult Index4()
        {
            ViewData["name"] = "Paul";
            ViewData["List"] = new List<string>() { "Mark", "Paul", "John" };
            return View();
        }

        public IActionResult Index5()
        {

            ViewData["List"] = new List<Employee>
            {
                new Employee { Id = 1, Name = "Mark", Email = "mark@example.com" },
                new Employee { Id = 2, Name = "Paul", Email = "paul@example.com" },
                new Employee { Id = 3, Name = "John", Email = "john@example.com" }
            };


            return View();
        }
    }
}
