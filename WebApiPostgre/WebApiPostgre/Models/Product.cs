using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiPostgre.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [Column(TypeName = "decimal(15, 2)")] // Указывает тип столбца в базе данных
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string Category { get; set; }

        public string ImageUrl { get; set; } // URL изображения продукта

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Дата и время создания записи
    }
}
