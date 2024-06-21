using Databasefirstapproach.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Databasefirstapproach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly modeldatabaseContext _context;

        public ProductController(modeldatabaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            //return Ok(_context.Products.Include(p => p.Orders));
            return Ok(_context.GetProduct());

        }
        [HttpPost]
        public IActionResult PostProducts([FromBody] Product product)
        {
            //    int id = _context.Products.OrderByDescending(p => p.ProductId).FirstOrDefault();
            //int ProductId = _context.Products.OrderByDescending(p => p.ProductId).Select(p => p.ProductId).FirstOrDefault();

            if (ModelState.IsValid)
            {
                _context.InsertProduct(product.ProductName, product.Price, product.StockQuantity);
                return Ok("Product created successfully");
            }
            return BadRequest("Invalid input");
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateProduct(int id, [FromBody] Product product) 
        {
            var productToUpdate = _context.Products.Find(id);
            if(productToUpdate != null) 
            {
                //productToUpdate.ProductName = product.ProductName;
                //productToUpdate.Price = product.Price;
                //productToUpdate.StockQuantity = product.StockQuantity;
                //_context.UpdateProduct(productToUpdate,Product product);
                _context.UpdateProduct(product);
                return Ok(productToUpdate);

            }
            return BadRequest();

        }

    }
}
