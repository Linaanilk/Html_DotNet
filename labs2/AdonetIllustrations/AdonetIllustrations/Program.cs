using AdonetIllustrations.Model;
using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace AdonetIllustrations
{
    public class Program
    {
 
        static SqlConnection _connection;
        static SqlCommand _command;
        static SqlDataReader _reader;
        static string _connectionString = "server=SPCOKLAP-5536\\SQLEXPRESS;database=modeldbtwo;Trusted_Connection=yes";

        static void Main()
        {
            // Perform a SELECT query
            SelectProducts();

            // Optionally, you can perform other operations or close the connection here
            _connection.Close();
        }

        static void SelectProducts()
        {
            using (_connection = new SqlConnection(_connectionString))
            {
                string selectQuery = "SELECT ProductId, ProductName, Price, StockQuantity FROM Product";

                using (_command = new SqlCommand(selectQuery, _connection))
                {
                    try
                    {
                        _connection.Open();

                        using (_reader = _command.ExecuteReader())
                        {
                            while (_reader.Read())
                            {
                                int productId = _reader.GetInt32(0); // Assuming the first column is ProductId
                                string productName = _reader.GetString(1); // Assuming the second column is ProductName
                                decimal price = _reader.GetDecimal(2); // Assuming the third column is Price
                                int stockQuantity = _reader.GetInt32(3); // Assuming the fourth column is StockQuantity

                                Console.WriteLine($"Product ID: {productId}, Name: {productName}, Price: {price}, Stock: {stockQuantity}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
        }
    }

   
    
   
}
