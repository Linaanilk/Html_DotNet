using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPI12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello Guest";
        }
        //[HttpGet("{FirstName}")]
        [HttpGet]
        [Route("{FirstName}")]
        public string Get(string FirstName) 
        {
            return "Hello" +" "+ FirstName;
        }
        [HttpGet]
        [Route("{FirstName}/{LastName}")]
        public string Get(string FirstName, string LastName) 
        {
            return"Hello"+" "+ FirstName +" "+ LastName;
        }
    }
}
