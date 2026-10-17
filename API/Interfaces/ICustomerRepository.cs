using API.Entities;

namespace API.Interfaces;

public interface ICustomerRepository
{
    Task<IReadOnlyList<Customer>> GetCustomerAsync();
}
