using ADONET.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace ADONET.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class PoductController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public PoductController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("GetAllProducts")]
        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {

           
            SqlConnection conn = new SqlConnection("Server=SPCOKLAP-5536\\SQLEXPRESS;Database=modeldbtwo;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=True");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Product";

            //open() method is used to open the connection
            conn.Open();
            List<ProductModel> list = new List<ProductModel>();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                ProductModel model = new ProductModel();
                model.ProductId = Convert.ToInt32(sqlDataReader["ProductId"]);
                model.ProductName = sqlDataReader["ProductName"].ToString();
                model.Price = Convert.ToInt32(sqlDataReader["Price"]);
                model.StockQuantity = Convert.ToInt32(sqlDataReader["StockQuantity"]);

                // Add the model to the list
                list.Add(model);
            }

            // Close() method is used to close the connection
            conn.Close();

            // Return the list as an Ok result in a Web API context
            return Ok(list);

           
        }
        [Route("CreateProducts")]
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductModel product)
        {


            SqlConnection conn = new SqlConnection("Server=SPCOKLAP-5536\\SQLEXPRESS;Database=modeldbtwo;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=True");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = $"INSERT INTO Product VALUES ('{product.ProductName}',{product.Price},{product.StockQuantity})";

            //open() method is used to open the connection
            
            
            int rows = cmd.ExecuteNonQuery();

            

            // Close() method is used to close the connection
            conn.Close();

            // Return the list as an Ok result in a Web API context
            return Ok();


        }
        [Route("UpdateProducts")]
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(int id,[FromBody] ProductModel product)
        {


            SqlConnection conn = new SqlConnection("Server=SPCOKLAP-5536\\SQLEXPRESS;Database=modeldbtwo;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=True");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            
            cmd.CommandText = "UpdateProductSP";
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.CommandText = $"UPDATE Product SET ProductName='{product.ProductName}',Price={product.Price},StockQuantity={product.StockQuantity} WHERE ProductId={product.ProductId}";
            cmd.CommandText = "UpdateProductSP";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
            cmd.Parameters.AddWithValue("@ProductName", product.ProductName);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
            //open() method is used to open the connection


            int rows = cmd.ExecuteNonQuery();



            // Close() method is used to close the connection
            conn.Close();

            // Return the list as an Ok result in a Web API context
            return Ok();


        }
        [Route("DeleteProduct")]
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {


            SqlConnection conn = new SqlConnection("Server=SPCOKLAP-5536\\SQLEXPRESS;Database=modeldbtwo;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=True");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();

            cmd.CommandText = "DeleteProductSP";
            cmd.CommandType = CommandType.StoredProcedure;
          
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductId", id);
         
            //open() method is used to open the connection


            int rows = cmd.ExecuteNonQuery();



            // Close() method is used to close the connection
            conn.Close();

            // Return the list as an Ok result in a Web API context
            return Ok();


        }


    }

}

