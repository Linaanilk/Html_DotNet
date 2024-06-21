using Speridian.EMS.Entities;
using Speridian.EMS.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.EMS.DAL
{
    public class EmployeeDAL
    {
        static List <Employee> list = new List<Employee>
        {
            new Employee 
            {   Id=1,
                Name="ketaki",
                DateOfBirth=new DateTime(2000,1,1),
                Email="ketaki@speridian.com",
                Gender=Gender.Female,
                MobileNo=9876543217,
                DepartmentId=1,
            },

            new Employee
            {   Id=2,
                Name="ketan",
                DateOfBirth=new DateTime(2001,11,1),
                Email="ketan@speridian.com",
                Gender=Gender.Male,
                MobileNo=9876543333,
                DepartmentId=2,
            }
        };
        static int counter = 2;
        public static List<Employee> GetEmployees()
        {
            return list;
        }
        public static bool Add(Employee employee)
        {
            bool isExists = list.Exists(e => e.Name == employee.Name && e.DateOfBirth==employee.DateOfBirth);
            if (isExists)
            {
                throw new EMSException("Employee already Exists");
            }
            employee.Id = ++counter;
            list.Add(employee);
            return true;
        }
        public static void Delete(int id)
        {
            bool isExists = list.Exists(e => e.Id == id );
            if (isExists)
            {
                list.RemoveAll(e=>e.Id==id);
                Console.WriteLine("Deleted successfully");
            }
            else
            {
                Console.WriteLine("error");
            }
           /// employee.Id = ++counter;
           
            //return true;
        }
        public static Employee GetById(int id)
        {
            var emp = list.Find(d => d.Id == id);
            return emp;
        }
        public static bool Update(int id, string name, DateTime dob, Gender gender, string email, long phone,int deptid)
        {
            Employee itemToUpdate = list.Find(e => e.Id == id);
            if (itemToUpdate != null)
            {
                itemToUpdate.Name = name;
                itemToUpdate.DateOfBirth = dob;
                itemToUpdate.Gender = gender;
                itemToUpdate.Email = email;
                itemToUpdate.MobileNo = phone;
                itemToUpdate.DepartmentId = deptid;
                return true;
            }
            return false;
        }
    }
}
