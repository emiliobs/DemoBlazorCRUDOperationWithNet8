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

        public async Task<Product> DeleteProductAsync(int productId)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == productId);

            if (product is null)
            {
                return null;
            }

            _context.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

        public async Task<List<Product>> GetAllProductAsync() => await _context.Products.ToListAsync();

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            var findProduct = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == productId);
            
            if(findProduct is null)
            {
                return null; 
            }

            return findProduct;


        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            var findProduct = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == product.ProductId);

            if (findProduct is null)
            {
                return null;
            }

            product.Name = product.Name;
            product.Quantity = product.Quantity;

            return product;
        }

        
    }
}
