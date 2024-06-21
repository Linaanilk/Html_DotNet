
namespace WebApplicationAPI13.Model
{
    public class EmployeeDbService : IEmployeeService
    {
        private DatabaseContext _dbContext;

        public EmployeeDbService(DatabaseContext context)
        {
            _dbContext = context;
        }
        public Employee AddEmployee(Employee employee)
        {
           _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employeeSaved= GetEmployeeById(id);
            _dbContext.Employees.Remove(employeeSaved);
            _dbContext.SaveChanges();
            return employeeSaved;
        }

        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.ToList();
          
        }

        public Employee GetEmployeeById(int id)
        {
            return _dbContext.Employees.FirstOrDefault(emp => emp.Id == id);
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
