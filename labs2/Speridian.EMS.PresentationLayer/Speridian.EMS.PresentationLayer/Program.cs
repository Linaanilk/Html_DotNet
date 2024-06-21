using Speridian.EMS.BusinessLayer;
using Speridian.EMS.Entities;
using Speridian.EMS.Exceptions;
using System.Text.RegularExpressions;

namespace Speridian.EMS.PresentationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("===================");
                    Console.WriteLine("1. LIST DEPARTMENTS");
                    Console.WriteLine("2. LIST EMPLOYEES");
                    Console.WriteLine("3. ADD DEPARTMENT");
                    Console.WriteLine("4. UPDATE DEPARTMENT");
                    Console.WriteLine("5. ADD EMPLOYEE");
                    Console.WriteLine("6. UPDATE EMPLOYEE");
                    Console.WriteLine("7. DELETE EMPLOYEE");
                    Console.WriteLine("8. EXIT");
                    Console.WriteLine("ENTER YOUR CHOICE");

                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int choice))
                    {
                        Console.WriteLine("Invalid Input");
                        return;
                    }
                    switch (choice)
                    {
                        case 1:
                            ListDepartments();
                            break;
                        case 2:
                            ListEmployees();
                            break;
                        case 3:
                            AddDepartment();
                            break;
                        case 4:
                            UpdateDepartment();
                            break;
                        case 5:
                            AddEmployee();
                            break;
                        case 6:
                            UpdateEmployee();
                            break;
                        case 7:
                            DeleteEmployee();
                            break;
                        case 8:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                }

                catch (EMSException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void ListDepartments()
        {
            var list=DepartmentBL.GetDepartments();
            foreach(var dept in list) 
            {
                Console.WriteLine(dept);
            }
        }
        static void ListEmployees()
        {
            var list = EmployeeBL.GetEmployees();
            foreach (var emp in list)
            {
                Console.WriteLine(emp);
            }
        }

        static void AddDepartment()
        {
            Console.WriteLine("Enter department name");
            string input=Console.ReadLine();
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid input");
                return;        
            }
            Department dept= new Department();
            dept.Name = input;
            bool isAdded = DepartmentBL.Add(dept);
            if(isAdded)
            {
                Console.WriteLine("Department Added successfully");
            }
            else
            {
                Console.WriteLine("Add department failed");
            }
        }
        static void DeleteEmployee()
        {
            Console.WriteLine("enter an id");
            string input=Console.ReadLine();
            if(!int.TryParse(input, out int id))
            {
                Console.WriteLine("Invalid");
                return;
            }
            EmployeeBL.Delete(id);
        }
        static void AddEmployee()
        {
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.WriteLine("Enter Date Of Birth");
            string input = Console.ReadLine();
            if (!DateTime.TryParse(input, out DateTime dob)|| dob>DateTime.Now)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter Gender");
            string genderInput=Console.ReadLine();
            if (!Enum.TryParse<Gender>(genderInput, true, out Gender gender))
            {
                Console.WriteLine("Invalid gender input");
                return;
            }
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            ListDepartments();
            Console.WriteLine("Choose department");
            string inp=Console.ReadLine();
            if (!int.TryParse(inp, out int deptid)) 
            {
                Console.WriteLine("Invalid dept");
                return;
            }
            var dept = DepartmentBL.GetById(deptid);
            if (dept == null)
            {
                Console.WriteLine("Invalid department id");
                return;
            }
            Console.WriteLine("Enter Phone no");
            string input1 = Console.ReadLine();
            if (!long.TryParse(input1, out long phone) || phone.ToString().Length != 10)
            {
                Console.WriteLine("Invalid input");
                return;
            }

         

            Employee emp = new Employee();
            emp.Name = name;
            emp.Email = email;
            emp.DateOfBirth = dob;
             emp.Gender = gender;
            emp.MobileNo = phone;
            emp.DepartmentId = deptid;

            bool isAdded = EmployeeBL.Add(emp);
            if (isAdded)
            {
                Console.WriteLine("Employee Added successfully");
            }
            else
            {
                Console.WriteLine("Add employee failed");
            }
        }

        public static void UpdateDepartment()
        {
            ListDepartments();
            Console.WriteLine("Enter department id to update");
            string input= Console.ReadLine();
            if(!int.TryParse(input, out int id))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            var dept=DepartmentBL.GetById(id);
            if(dept == null) 
            {
                Console.WriteLine("Invalid department id");
                return;
            }
            else
            {
                Console.WriteLine("Enter new department name");
                string input1=Console.ReadLine();
                if(string.IsNullOrEmpty(input1))
                {
                    Console.WriteLine("Invalid Input");
                    return;
                }
                if(DepartmentBL.Update(id, input1))
                {
                    Console.WriteLine("updated");
                }
                else 
                {
                    Console.WriteLine("Not updated");
                }
            }

        }

        public static void UpdateEmployee()
        {
            ListEmployees();
            Console.WriteLine("Enter employee id to update");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int id))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            var emp = EmployeeBL.GetById(id);
            if (emp == null)
            {
                Console.WriteLine("Invalid employee id");
                return;
            }
            else
            {
                Console.WriteLine("Enter new Employee name");
                string name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Invalid Input");
                    return;
                }

                Console.WriteLine("Enter Date Of Birth");
                string input2 = Console.ReadLine();
                if (!DateTime.TryParse(input2, out DateTime dob)||dob>DateTime.Now)
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                Console.WriteLine("Enter Gender");
                string genderInput = Console.ReadLine();
                if (!Enum.TryParse<Gender>(genderInput, true, out Gender gender))
                {
                    Console.WriteLine("Invalid gender input");
                    return;
                }
                Console.WriteLine("Enter Email");
                string email = Console.ReadLine();
                if (string.IsNullOrEmpty(email) || !Regex.IsMatch(input, "^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$"))
                {
                    Console.WriteLine("Invalid input");
                    return;
                }

                Console.WriteLine("Enter Phone no");
                string input3 = Console.ReadLine();
                if (!long.TryParse(input3, out long phone) || phone.ToString().Length != 10)
                {
                    Console.WriteLine("Invalid input");
                    return;
                }
                ListDepartments();
                Console.WriteLine("Choose department");
                string inp = Console.ReadLine();
                if (!int.TryParse(inp, out int deptid))
                {
                    Console.WriteLine("Invalid dept");
                    return;
                }

                if (EmployeeBL.Update(id,name,dob,gender,email,phone,deptid))
                {
                    Console.WriteLine("updated");
                }
                else
                {
                    Console.WriteLine("Not updated");
                }
            }

        }

    }
}
