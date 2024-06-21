using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class MyDbContext: DbContext
    {
        string connectionString = "server=SPCOKLAP-5536\\SQLEXPRESS;database=StudentDB;Trusted_Connection=yes";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Student> Students { get; set; }
    }
}
