using Speridian.EMS.DAL;
using Speridian.EMS.Entities;
using System.Numerics;
using System.Reflection;

namespace Speridian.EMS.BusinessLayer
{
    public class EmployeeBL
    {
        public static List<Employee> GetEmployees()
        {
            var list = EmployeeDAL.GetEmployees();
            return list;
        }
        public static bool Add(Employee employee)
        {
            var isadded = EmployeeDAL.Add(employee);
            return isadded;
        }
        public static void Delete(int id)
        {
            EmployeeDAL.Delete(id);
        }
        public static Employee GetById(int id)
        {
            var emp = EmployeeDAL.GetById(id);
            return emp;
        }
        public static bool Update(int id, string name,DateTime dob,Gender gender,string email,long phone,int deptid)
        {
            return EmployeeDAL.Update(id, name,dob,gender,email,phone,deptid);
        }

    }
    
}
