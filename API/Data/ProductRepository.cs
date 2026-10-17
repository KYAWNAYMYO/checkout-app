using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class ProductRepository(AppDbContext context) : IProductRepository
{
    public async Task<IReadOnlyList<Product>> GetProductAsync()
    {
        return await context.Products.ToListAsync();
    }
}
