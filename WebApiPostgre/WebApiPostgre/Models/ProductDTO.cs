using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPostgre.Models
{
    public class ProductDTO
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }
    }
}
