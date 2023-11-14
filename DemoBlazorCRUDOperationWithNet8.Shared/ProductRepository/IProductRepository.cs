using DemoBlazorCRUDOperationWithNet8.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlazorCRUDOperationWithNet8.Shared.ProductRepository
{
    public interface IProductRepository
    {
       Task<Product> AddProductAsync(Product product);  

       Task<Product> UpdateProductAsync(Product product);
        
       Task<Product> DeleteProductAsync(int productId); 
       
       Task<Product> GetAllProductAsync();
        
       Task<Product> GetProductByIdAsync(int productId);





    }
}
