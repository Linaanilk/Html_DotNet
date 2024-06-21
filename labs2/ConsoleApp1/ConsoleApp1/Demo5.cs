using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Demo5
    {
        static void Main5()
        {
            string connectionString = "server=SPCOKLAP-5536\\SQLEXPRESS;database=SampleDB;Trusted_Connection=yes";
            SqlConnection conn = new SqlConnection(connectionString);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Employee;select * from Department;", conn);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            DataTable dt= new DataTable();
            dt = dataSet.Tables[0];

            DataTable dt2 = new DataTable();
            dt2 = dataSet.Tables[1];

           // for (int i=1,j=1;i<dt.Rows.Count; i++)
            //{
                Console.WriteLine(dt.Rows[0][0]);
            Console.WriteLine(dt2.Rows[0][0]);
            // }
        }
    }
}
