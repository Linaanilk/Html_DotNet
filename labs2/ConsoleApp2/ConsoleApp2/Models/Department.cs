using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
       
        public string DepartmentName { get; set; }
        //public List<Employee> Employees { get; set; }
    }
}
