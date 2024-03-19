using Microsoft.EntityFrameworkCore;

namespace FirstApp24.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }


    public class ProductsDB:DbContext
    {
        public DbSet<Product> Products { get; set;}

        public ProductsDB(DbContextOptions<ProductsDB> options)
           : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }

}
