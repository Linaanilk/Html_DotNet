using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Demo2
    {
        static void Main3()
        {
            Console.WriteLine("Add new employee");
            Console.WriteLine("Enter name:");
            string name=Console.ReadLine();

            Console.WriteLine("Enter Email");
            string email=Console.ReadLine();

            string connectionString = "server=SPCOKLAP-5536\\SQLEXPRESS;database=SampleDB;Trusted_Connection=yes";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Insert into Employee(Name,Email) values (' "+name +"',' " + email + " ')";

            conn.Open();
            int rows=cmd.ExecuteNonQuery();
            Console.WriteLine("(" + rows +")affected");
            conn.Close();

        }
    }
}
