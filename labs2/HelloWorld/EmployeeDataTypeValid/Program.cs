using System.Text.RegularExpressions;

namespace EmployeeDataTypeValid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee id");
            string input=Console.ReadLine();
            if (!int.TryParse(input,out int id) || id<=0)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Employee employee = new Employee(); 
            employee.Id = id;

            Console.WriteLine("Enter Name");
            input= Console.ReadLine();
            if (string.IsNullOrEmpty(input) || !Regex.IsMatch(input, "^[a-zA-Z]+$"))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
           // Employee employee = new Employee();
            employee.Name = input;

            Console.WriteLine("Enter BirthDate");
             input=Console.ReadLine();
            if (!DateTime.TryParse(input,out DateTime dtime))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
           
            employee.BirthDate = dtime;

            Console.WriteLine("Enter Email");
             input=System.Console.ReadLine();
            if (!Regex.IsMatch(input, "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
           
            employee.Email = input;

            string name = "Param";
            Console.WriteLine("welcome " + name);
            Console.WriteLine(string.Format("welcome {0}",name));
            Console.WriteLine("welcome {0}", name);
            Console.WriteLine($"welcome  {name}" );


        }
    }
}
