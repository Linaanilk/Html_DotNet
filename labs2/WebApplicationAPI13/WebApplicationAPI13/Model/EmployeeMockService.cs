
namespace WebApplicationAPI13.Model
{
    public class EmployeeMockService : IEmployeeService
    {
        private static List<Employee> employees;
        private int count = 3;

        public EmployeeMockService()
        {
            employees = new List<Employee>();
            employees.Add(new Employee() { Id=101,   Name="Mark",   Email="m@gmail.com"});
            employees.Add(new Employee() { Id = 102, Name = "Paul", Email = "p@gmail.com" });
            employees.Add(new Employee() { Id = 103, Name = "John", Email = "j@gmail.com" });
        }
        public Employee AddEmployee(Employee employee)
        {
            employee.Id = ++count;
            employees.Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee =GetEmployeeById(id);
            employees.Remove(employee);
            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
           return employees;
        }

        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(emp => emp.Id == id);
        }

        public Employee UpdateEmployee(int id, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
