using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Demo6
    {
        static void Main()
        {
            string connectionString = "server=SPCOKLAP-5536\\SQLEXPRESS;database=SampleDB;Trusted_Connection=yes";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Employee", conn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            DataTable dt = new DataTable();
            dt = dataSet.Tables[0];

         

           
            Console.WriteLine(dt.Rows[1][1]);
          
            
        }
    }
}

