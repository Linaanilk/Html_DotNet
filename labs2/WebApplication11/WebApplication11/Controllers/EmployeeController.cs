using Microsoft.AspNetCore.Mvc;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService employeeService;

        public EmployeeController()
        {
            employeeService= new EmployeeService();
        }
        [Route("/")]
        public IActionResult Index() 
        {
        var data=employeeService.GetAllEmployees();
            return View(data);
        }
        //public IActionResult Delete(int id)
        //{
        //    //if (employeeService.DeleteEmployee(id))
        //    //{
        //    //    return View();
        //    //}
        //    //else
        //    //    return RedirectToAction("Index");
        //    var employee = employeeService.GetEmployeeById(id);
        //    if (employee == null)
        //    {
        //        return NotFound(); // Handle the case where the employee is not found
        //    }

        //    return View(employee);
        //}



        //[Route("emp")]

        public IActionResult Delete(int id)
        {
            // Retrieve the employee by ID
            var employee = employeeService.GetEmployeeById(id);

            // Check if the employee exists
            if (employee == null)
            {
                return NotFound(); // Handle the case where the employee is not found
            }

            return View(employee);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            // Implement the deletion logic in your service
            if (employeeService.DeleteEmployee(id))
            {
                return RedirectToAction("Index");
            }
            else
            {
                // Handle the case where deletion fails (e.g., log an error)
                return View("Error");
            }
        }

        public IActionResult Add()
        {
            //var data = employeeService.AddEmployee(employee);
            return View();
        }
        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            var data = employeeService.AddEmployee(employee);
            return RedirectToAction("Index");
        }

        //public IActionResult Edit(int id)
        //{
        //    // Retrieve the employee from the database by id
        //    var employee = employeeService.GetEmployeeById(id);

        //    if (employee == null)
        //    {
        //        return NotFound(); // Handle the case where the employee is not found
        //    }

        //    return View(employee);
        //}

        //[HttpPost]
        //public IActionResult Edit(int id, Employee employee)
        //{
        //    if (id != employee.Id)
        //    {
        //        return BadRequest(); // Ensure the id in the URL matches the id in the model
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        employeeService.UpdateEmployee(id, employee);
        //        return RedirectToAction("Index");
        //    }

        //    // If the model state is not valid, return the view with validation errors
        //    return View(employee);
        //}
        public IActionResult Edit()
        {
            //var data = employeeService.AddEmployee(employee);
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            var data = employeeService.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {

            var data = employeeService.GetEmployeeById(id);
            return View(data);
        }
    }
}
