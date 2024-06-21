using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Mark",
                Email = "cgsd"
            };
            return View(student);
        }
        [HttpPost]
        public IActionResult Index(Student student)
        {
           
            return View();
        }
    }
}
