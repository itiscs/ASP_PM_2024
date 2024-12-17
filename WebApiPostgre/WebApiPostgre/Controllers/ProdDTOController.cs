using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiPostgre.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiPostgre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdDTOController : ControllerBase
    {

        private readonly ProductsContext _context;

        public ProdDTOController(ProductsContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProdDTO()
        {
            return await _context.Products.Select(p=>
            new ProductDTO() { 
                 Name = p.Name,
                 Price = p.Price,
                 StockQuantity = p.StockQuantity
            }).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProdDTO(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return new ProductDTO() { Name = product.Name,
                                      Price = product.Price,
                                      StockQuantity = product.StockQuantity};
        }


    }
}
