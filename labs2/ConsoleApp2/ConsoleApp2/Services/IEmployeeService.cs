using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
      
        Employee GetEmployeeById(int id);

        Employee AddEmployee(Employee newEmployee);
        Employee UpdateEmployee(int id,Employee updateEmployee);

        void DeleteEmployee(int id);


    }
}
