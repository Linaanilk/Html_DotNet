using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Employee
    {
        public int id { get; set; }

        [Column("Employee_name")]
        public string Name { get; set; }
        [Column(TypeName ="char(500)")]
        [Required]

        public string Email { get; set; }

        public Department Department { get; set; }
        


    }
}
