using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
      public string Hello()
        {
            return "Hello from student";
        }
        public string Profile(int id)
        {
            return "Profile: " + id;
            //http://localhost:5008/Student/Profile?id=111
        }
        public string Index() 
        {
            return "Index";
            //http://localhost:5008/Student
        }
        public string Name(string firstname,string lastname)
        {
            return "Name: "+firstname+" "+lastname;

            //http://localhost:5008/Student/Name?firstname=Mark&lastname=Antony
        }
    }
}
