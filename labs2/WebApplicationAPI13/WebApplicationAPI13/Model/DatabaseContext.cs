using Microsoft.EntityFrameworkCore;

namespace WebApplicationAPI13.Model
{
    public class DatabaseContext:DbContext

    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=SPCOKLAP-5536\\SQLEXPRESS;database=EmployeeAPI;Trusted_connection=yes");
        //}

        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
        
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
