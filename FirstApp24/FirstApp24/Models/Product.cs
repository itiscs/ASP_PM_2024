using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations.Schema;

namespace FirstApp24.Models
{

    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Display(Name="Наименование")]
        [StringLength(20)]  
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string? Description { get; set; }

        [Range(0,1000,ErrorMessage = "Цена от 0 до 1000")]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }
        //[RegularExpression("")]
        //[Compare()]
        [Display(Name = "Количество")]
        public int Count { get; set; }
    }


    public class ProductsDB:DbContext
    {
        public DbSet<Product> Products { get; set;}

        public ProductsDB(DbContextOptions<ProductsDB> options)
           : base(options)
        {
           // Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }

}
