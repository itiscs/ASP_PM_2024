using Microsoft.AspNetCore.Authentication;
using WebApiPostgre.Data;
using WebApiPostgre.Models;

namespace WebApiPostgre.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductsContext _db;
        public ProductRepository(ProductsContext db) 
        {
            _db = db;
        }
        public async Task AddProduct(Product prod)
        {
            await _db.AddAsync(prod);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProduct(int id)
        {
            var prod = await GetProductByID(id);
            _db.Products.Remove(prod);
            await _db.SaveChangesAsync();
        }

        public async Task<Product> GetProductByID(int id)
        {
            return await _db.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return _db.Products.ToList();
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }

        public async Task UpdateProducts(Product prod)
        {
            _db.Update(prod);
        }
    }
}
