namespace WebApplicationAPI13.Model
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();

        Employee GetEmployeeById(int id);

        Employee AddEmployee(Employee employee);

        Employee UpdateEmployee(int id,Employee employee);

        Employee DeleteEmployee(int id);
    }
}
