using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI12.NewFolder;

namespace WebApplicationAPI12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public List<Employee> Get()
        {
            return GenerateData();
        }

        [HttpGet("{id}")]
        public Employee Get(int id) 
        {
            return GenerateData().FirstOrDefault(emp=>emp.Id==id);
        }
       
        private List<Employee> GenerateData() 
        {
            return new List<Employee>
        {
            new Employee { Id = 1,Name="chinnu",Email="c@gmail.com"},
            new Employee { Id = 2,Name="Laya",Email="l@gmail.com"},
            new Employee { Id = 3,Name="Krithi",Email="k@gmail.com"},

        };
        }
    }
}
