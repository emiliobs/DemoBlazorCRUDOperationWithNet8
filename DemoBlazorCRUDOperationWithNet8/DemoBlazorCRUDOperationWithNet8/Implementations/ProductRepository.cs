using DemoBlazorCRUDOperationWithNet8.Data;
using DemoBlazorCRUDOperationWithNet8.Shared.Models;
using DemoBlazorCRUDOperationWithNet8.Shared.ProductRepository;
using Microsoft.EntityFrameworkCore;

namespace DemoBlazorCRUDOperationWithNet8.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            if (product is null)
            {
                return null;
            }

            var existProduct = await _context.Products
                                             .Where(p => p.Name.ToLower().Equals(product.Name.ToLower())).FirstOrDefaultAsync();

            if (existProduct is not null)
            {
                return null;
            }

           var newDataAdded  = _context.Products.Add(product).Entity;
            await _context.SaveChangesAsync();

            return newDataAdded; 
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
