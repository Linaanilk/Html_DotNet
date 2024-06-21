using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI13.Model;

namespace WebApplicationAPI13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
           // _employeeService = new EmployeeMockService();
           this.employeeService = employeeService;
        }
        [HttpGet]

        public List<Employee> Get() 
        {
            var data=employeeService.GetAllEmployees();
            return data;
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            var data = employeeService.GetEmployeeById(id);
            return data;
                
        }
        [HttpPost]
        public Employee Post(Employee employee) 
        {
        var data=employeeService.AddEmployee(employee);
            return data;
        }
        //[HttpDelete("{id}")]
        [HttpDelete]
        [Route("{id}")]
        public string Delete(int id)
        {
        employeeService.DeleteEmployee(id);
            return "Employee deleted successfully";

        }
        [HttpPut("{id}")]
        public Employee Put(int id,Employee employee) 
        {
        employeeService.UpdateEmployee(id, employee);
            return employee;
        }
        

    }
}
