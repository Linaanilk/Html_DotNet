using ConsoleApp2.Database;
using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Services
{
    public class EmployeeService : IEmployeeService
    {
        private DatabaseContext _context;


         public EmployeeService() 
        {
            _context = new DatabaseContext();
        }
        public Employee AddEmployee(Employee newEmployee)
        {
            _context.Employees.Add(newEmployee);
            _context.SaveChanges();
            return newEmployee;
        }

        public void DeleteEmployee(int id)
        {
            Employee saveEmp = _context.Employees.FirstOrDefault(emp => emp.id == id);
            _context.Employees.Remove(saveEmp);
            _context.SaveChanges();
        }

        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.FirstOrDefault(emp => emp.id == id);
        }

        public Employee UpdateEmployee(int id, Employee updateEmployee)
        {
            var emp = _context.Employees.FirstOrDefault(emp2 => emp2.id == id);
            emp.Name=updateEmployee.Name;
            emp.Email=updateEmployee.Email;
            _context.Employees.Update(emp);
            _context.SaveChanges();
            return emp;
        }
    }
}
