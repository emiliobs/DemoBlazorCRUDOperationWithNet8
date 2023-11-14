using DemoBlazorCRUDOperationWithNet8.Data;
using DemoBlazorCRUDOperationWithNet8.Shared.Models;
using DemoBlazorCRUDOperationWithNet8.Shared.ProductRepository;

namespace DemoBlazorCRUDOperationWithNet8.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            this._context = context;
        }

        public Task<Product> AddProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAllProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
