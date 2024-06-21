using System.Data.SqlClient;
namespace ConsoleApp1
{
    internal class Demo1
    {
        static void Main2(string[] args)
        {   
            //connected architecture
            //connection string
            string connectionString = "server=SPCOKLAP-5536\\SQLEXPRESS;database=SampleDB;Trusted_Connection=yes";
           
            //sql connection class used to provide connection between app and dtabase
            SqlConnection conn= new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Employee";

            //open() method is used to open the connection
            conn.Open();

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while(sqlDataReader.Read())
            {
                string id = sqlDataReader["id"].ToString();
                string name = sqlDataReader["Name"].ToString();
                string email = sqlDataReader["Email"].ToString();
                Console.WriteLine("Id: "+id+", Name: "+name+",Email: "+email);
            }


            //Close() method is used to close the connection
            conn.Close();

            Console.ReadKey();  
        }
    }
}
