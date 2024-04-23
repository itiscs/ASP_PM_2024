using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace IdentityApp.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Наименование")]
        [StringLength(20)]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string? Description { get; set; }

        [Range(0, 1000, ErrorMessage = "Цена от 0 до 1000")]
        [Display(Name = "Цена")]
        public decimal Price { get; set; }
    
        [Display(Name = "Количество")]
        public int Count { get; set; }
    }
}
