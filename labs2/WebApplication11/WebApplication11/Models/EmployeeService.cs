
namespace WebApplication11.Models
{
    public class EmployeeService:IEmployeeService
    {
        private DatabaseContext _dbContext; 

       
        public EmployeeService() 
        {
        _dbContext = new DatabaseContext();
        }

        public Employee AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }


        public Employee UpdateEmployee(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges();
            return employee;
        }

        public bool DeleteEmployee(int id)
        {
            // Find the employee by ID
            Employee employeeToDelete = _dbContext.Employees.FirstOrDefault(emp => emp.Id == id);

            // Check if the employee exists
            if (employeeToDelete == null)
            {
                // Employee not found, return false or throw an exception, depending on your application's logic
                return false;
            }

            // Remove the employee from the DbSet
            _dbContext.Employees.Remove(employeeToDelete);

            // Save changes to the database
            _dbContext.SaveChanges();

            // Return true to indicate successful deletion
            return true;
        }


        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _dbContext.Employees.FirstOrDefault(stud => stud.Id == id);
        }

        //public Employee UpdateEmployee(int id, Employee employee)
        //{
           
        //    Employee existingEmployee = _dbContext.Employees.FirstOrDefault(emp => emp.Id == id);

        //    if (existingEmployee != null)
        //    {
                
        //        existingEmployee.Name = employee.Name;
        //        existingEmployee.Email = employee.Email;
              

               
        //        _dbContext.SaveChanges();

             
        //        return existingEmployee;
        //    }

           
        //    return null;
        //}

    }
}
