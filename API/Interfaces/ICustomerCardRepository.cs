using API.Entities;

namespace API.Interfaces;

public interface ICustomerCardRepository
{
    Task<IReadOnlyList<CustomerCard>> GetCustomerCardAsync();

    
}
