using ConsoleApp2.Models;
using ConsoleApp2.Services;

namespace ConsoleApp2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           IEmployeeService service = new EmployeeService();

            bool flag = true;

            while (flag) 
            {
                Console.WriteLine("===================");
                Console.WriteLine("Choose any option");
                Console.WriteLine("===================");
                Console.WriteLine("PRESS 1: ADD EMPLOYEE");
                Console.WriteLine("PRESS 2: UPDATE EMPLOYEE");
                Console.WriteLine("PRESS 3: DELETE EMPLOYEE");
                Console.WriteLine("PRESS 4:GET ALL EMPLOYEES");
                Console.WriteLine("PRESS 5:GET EMPLOYEES BY ID");
                Console.WriteLine("PRESS 6: EXIT");

                string input= Console.ReadLine();
                if(!int.TryParse(input,out int inp))
                {
                    Console.WriteLine("Invalid Input");
                    return;

                }

                switch(inp) 
                {
                    case 1:
                        Console.WriteLine("ADD EMPLOYEE");
                        Console.WriteLine("==============");
                        Console.WriteLine("Enter Name of the employee");
                        string name= Console.ReadLine();
                      
                        Console.WriteLine("Enter Email");
                        string email= Console.ReadLine();

                        //Console.WriteLine("Enter Department id");
                        //string inp3 = Console.ReadLine();
                        //if (!int.TryParse(inp3, out int id5))
                        //{
                        //    Console.WriteLine("Invalid Input");
                        //    return;

                        //}


                        Employee employee= new Employee();
                        employee.Name = name;
                        employee.Email = email;
                        //Department.Department = id5;

                        service.AddEmployee(employee);
                        Console.WriteLine("Employee Added successfully");
                        break;

                    case 2:
                        Console.WriteLine("UPDATE EMPLOYEE");
                        Console.WriteLine("==============");
                        Console.WriteLine("Enter Employee id");
                        string input2 = Console.ReadLine();
                        if (!int.TryParse(input2, out int id3))
                        {
                            Console.WriteLine("Invalid Input");
                            return;

                        }

                        Console.WriteLine("Enter Name of the employee");
                         name = Console.ReadLine();

                        Console.WriteLine("Enter Email");
                         email = Console.ReadLine();

                        Employee employee2 = new Employee();
                        employee2.Name = name;
                        employee2.Email = email;

                        service.UpdateEmployee(id3,employee2);
                        Console.WriteLine("Employee Updated successfully");
                        break;

                    case 3:
                        Console.WriteLine("DELETE EMPLOYEE");
                        Console.WriteLine("==============");
                        Console.WriteLine("Enter Employee id");
                         input2 = Console.ReadLine();
                        if (!int.TryParse(input2, out int id2))
                        {
                            Console.WriteLine("Invalid Input");
                            return;

                        }
                        Employee employee3 = new Employee();
                      

                        service.DeleteEmployee(id2);
                        Console.WriteLine("Employee Deleted successfully");
                        break;
                    case 4:
                        Console.WriteLine(" EMPLOYEE DETAILS");
                        Console.WriteLine("==============");
                        var det = service.GetAllEmployees();

                        foreach (var item in det)
                        {
                            Console.WriteLine($"ID: {item.id}, Name: {item.Name}, Email: {item.Email}");
                        }
                        break;
                  
                    case 5:
                        Console.WriteLine("GET EMPLOYEES BY ID");
                        Console.WriteLine("==============");
                        Console.WriteLine("Enter id");
                        string input4 = Console.ReadLine();

                        if (!int.TryParse(input4, out int id))
                        {
                            Console.WriteLine("Error: Invalid ID");
                            return;
                        }

                        var det2 = service.GetEmployeeById(id);
                        
                            if (det2 != null)
                            {
                                Console.WriteLine($"Name: {det2.Name}, Email: {det2.Email}");
                            }
                            else
                            {
                                Console.WriteLine("Employee not found");
                            }
                        
                        break;
                    case 6:
                        Console.WriteLine("Thank you");
                        Environment.Exit(0);
                        break;
                }
            }

    }
    }
}
