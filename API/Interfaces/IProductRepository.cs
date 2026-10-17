using API.Entities;

namespace API.Interfaces;

public interface IProductRepository
{
    Task<IReadOnlyList<Product>> GetProductAsync();
}
