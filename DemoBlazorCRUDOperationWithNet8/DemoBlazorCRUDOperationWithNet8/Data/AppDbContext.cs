using DemoBlazorCRUDOperationWithNet8.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoBlazorCRUDOperationWithNet8.Data
{
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

    }
}
