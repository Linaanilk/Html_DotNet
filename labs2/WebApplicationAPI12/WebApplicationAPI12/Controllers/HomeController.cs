using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationAPI12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Get Method";
        }
        [HttpPost]
        public string Post() 
        {
            return "Post Method";
        }
        [HttpPut]
        public string Put()
        {
            return "put Method";
        }
        [HttpDelete]
        public string Delete()
        {
            return "Delete Method";
        }
    }
}
