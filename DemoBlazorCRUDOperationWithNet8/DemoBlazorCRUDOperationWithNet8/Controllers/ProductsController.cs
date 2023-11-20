using DemoBlazorCRUDOperationWithNet8.Shared.Models;
using DemoBlazorCRUDOperationWithNet8.Shared.ProductRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoBlazorCRUDOperationWithNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }


        [HttpGet("AllProduct")]
        public async Task<ActionResult<List<Product>>> GetAllProductAsync()
        {
            return Ok(_productRepository.GetAllProductAsync());  
        }

        [HttpGet("ProductById/{id}")]
        public async Task<ActionResult<Product>> GetProductByIdAsync(int id)
        {
            return Ok(_productRepository.GetProductByIdAsync(id));  
        }

        [HttpPost("AddProduct")]
        public async Task<ActionResult<Product>> AddProductAsync(Product product)
        {
            return Ok(_productRepository.AddProductAsync(product));  
        }

        [HttpPut("UpdateProduct")]
        public async Task<ActionResult<Product>> UpdateProductAsync(Product product)
        {
            return Ok(_productRepository.UpdateProductAsync(product));  
        }

        [HttpDelete("DeleteProduct/{id}")]
        public async Task<ActionResult<Product>> DeleteProductAsync(int id)
        {
            return Ok(_productRepository.DeleteProductAsync(id));
        }

    }
}
