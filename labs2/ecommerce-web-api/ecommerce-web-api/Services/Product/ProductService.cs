using ecommerce_web_api.Database;
using ecommerce_web_api.Models;
using ecommerce_web_api.Products;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
//using eCommerce_web_api.Services.Products;

namespace ecommerce_web_api.Services.Products
{
    public class ProductService : IProductService
    {
        private readonly DatabaseContext _context;

        public ProductService(DatabaseContext context)
        {
            _context = context;
        }
        public Product Add(int catId,Product product)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.CategoryId == catId);
            product.Category = category;
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }
        public Product Update(int catId, int pid,Product product)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.CategoryId == catId);
            product.Category = category;
           

            Product saveProduct = GetProductById(pid);
            if (saveProduct != null)
            {
                saveProduct.ProductName = product.ProductName;
                saveProduct.ProductDescription = product.ProductDescription;
                saveProduct.price = product.price;
                saveProduct.ProductImage = product.ProductImage;
                //saveProduct.CategoryId = product.CategoryId;
                saveProduct.Category = _context.Categories.FirstOrDefault(x => x.CategoryId == catId);
                _context.Products.Update(saveProduct);
                _context.SaveChanges();
                return saveProduct;
            }
            else
                return saveProduct;
        }



        public Product GetProductById(int id)
        {
            return _context.Products.Where(x => x.ProductId == id).Include(x => x.Category).FirstOrDefault();
        }
        public List<Product> GetProductByCatId(int cid)
        {

            return _context.Products.Where(x => x.Category.CategoryId == cid).Include(x => x.Category).ToList();
        }
       
        public List<Product> GetProducts()
        {
            return _context.Products.Include(c => c.Category).ToList();
        }

        public void DeleteProduct(int id)
        {
            Product product = GetProductById(id);
            _context.Products.Remove(product);
            _context.SaveChanges();
            
        }


    }
}
