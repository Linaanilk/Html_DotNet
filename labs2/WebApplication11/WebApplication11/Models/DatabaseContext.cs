using Microsoft.EntityFrameworkCore;

namespace WebApplication11.Models
{
    public class DatabaseContext:DbContext
    {
        string connectionString = "server=SPCOKLAP-5536\\SQLEXPRESS;database=MVCApp;Trusted_connection=yes";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
