using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {

        //[Route("students")]
        public IActionResult GetAllStudents()
        {
            var data=GenerateData();
            return View(data);
        }
        //[Route("students/{id}")]
        [Route("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var data=GenerateData().FirstOrDefault(x=>x.Id==id);
            return View(data);
        }
        //[Route("students/{id}/address")]
        [Route("{id}/address")]
        public IActionResult GetStudentAddressById(int id)
        {
            var data = GenerateData().Where(x => x.Id == id).Select(x => x.Address).FirstOrDefault();
            return View(data);
        }
        [Route("~/about")]
        [Route("~/aboutus")]
        [Route("~/about-us")]

        public IActionResult About()
        {
            return View();
        }
        private List<Student> GenerateData()
        {
            return new List<Student>()
            {
                new Student()
                {
                    Id=1,
                        Name="Mark",
                        Email="n@gmail.com",
                        Address=new Address()
                        {
                            HouseNumber=101,
                            City="City1",
                            Country="Country1"
                        }
                },
                 new Student()
                {
                    Id=2,
                        Name="Meera",
                        Email="meera@gmail.com",
                        Address=new Address()
                        {
                            HouseNumber=102,
                            City="City2",
                            Country="Country3"
                        }
                },
                  new Student()
                {
                    Id=3,
                        Name="Manu",
                        Email="manu@gmail.com",
                        Address=new Address()
                        {
                            HouseNumber=103,
                            City="City3",
                            Country="Country3"
                        }
                },
            };
        }
    }
}
