using WebApiPostgre.Models;

namespace WebApiPostgre.Data
{
    public interface IProductRepository
    {
            Task<IEnumerable<Product>> GetProducts();
            Task<Product> GetProductByID(int id);
            Task AddProduct(Product prod);
            Task DeleteProduct(int id);
            Task UpdateProducts(Product prod);
            Task Save();
        
    }
}
