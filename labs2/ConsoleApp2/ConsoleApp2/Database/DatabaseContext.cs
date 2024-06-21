using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Database
{
    public class DatabaseContext:DbContext
    {
        string connectionString = "server=SPCOKLAP-5536\\SQLEXPRESS;database=EmployeeDB;Trusted_Connection=yes";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
