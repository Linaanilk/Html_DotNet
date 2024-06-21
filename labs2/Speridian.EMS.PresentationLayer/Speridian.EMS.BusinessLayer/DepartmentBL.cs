using Speridian.EMS.DAL;
using Speridian.EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speridian.EMS.BusinessLayer
{
    public class DepartmentBL
    {
        public static List<Department>GetDepartments()
        {
            var list = DepartmentDAL.GetDepartments();
            return list;
        }
        public static bool Add(Department department)
        {
            var isadded=DepartmentDAL.Add(department);
            return isadded;
        }
       public static  Department GetById(int id) 
        {
        var dept=DepartmentDAL.GetById(id);
            return dept;
        }
        public static bool Update(int id, string name)
        {
            return DepartmentDAL.Update(id,name);
        }
    }
}
