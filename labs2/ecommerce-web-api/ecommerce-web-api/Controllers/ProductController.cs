using ecommerce_web_api.Models;
using ecommerce_web_api.Products;
using ecommerce_web_api.Services.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var data = _productService.GetProducts();
            return Ok(data);
        }
        [HttpGet("category/{catId}")]
        public ActionResult<Product> GetProductsByCatId(int catId)
        {
            var data = _productService.GetProductByCatId(catId);
            if (data == null)
            {
                return NotFound("No Product found with catId" + catId);
            }
            return Ok(data);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var data = _productService.GetProductById(id);
            if (data == null)
            {
                return NotFound("No Product found with Id" + id);
            }
            return Ok(data);
        }

        [HttpPost("{catId}")]
        public ActionResult<Product> PostProduct(int catId, Product product)
        {
            var data = _productService.Add(catId, product);

            return Ok(data);
        }
        [HttpPut("{catId}/{pid}")]
        public ActionResult<Product> PutProduct(int catId, int pid, Product product)
        {
            var data = _productService.Update(catId,pid, product);

            return Ok(data);
        }
        [HttpDelete("{id}")]
       
        public ActionResult<string> Delete(int id)
        {
            var data = _productService.GetProductById(id);
            if(data != null)
            {
                _productService.DeleteProduct(id);
                return Ok("deleted");
            }
            else { return NotFound($"product not found with id {id}"); }
            //return "Employee deleted successfully";

        }

    }
}
