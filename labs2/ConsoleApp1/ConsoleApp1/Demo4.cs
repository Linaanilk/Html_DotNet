using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Demo4
    {
        static void Main4()
        {

            Console.WriteLine("Delete employee");
            Console.WriteLine("Enter Id:");
            string id1 = Console.ReadLine();
            if (!int.TryParse(id1, out int Id))
            {
                Console.WriteLine("error");
                return;
            }
            

            string connectionString = "server=SPCOKLAP-5536\\SQLEXPRESS;database=SampleDB;Trusted_Connection=yes";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = cmd.CommandText = "Delete Employee WHERE Id = " + Id;


            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine("(" + rows + ")affected");
            conn.Close();
        }
    }
}
