using ecommerce_web_api.Models;
//using ECommerce_web_api.Models;

namespace ecommerce_web_api.Products
{
    public interface IProductService
    {
        List<Product> GetProducts();

        Product GetProductById(int id);
        Product Add(int catid,Product product);

        void DeleteProduct(int id);
        Product Update(int catid, int pid,Product product);

        List<Product> GetProductByCatId(int cid);

       
     

    }
}
