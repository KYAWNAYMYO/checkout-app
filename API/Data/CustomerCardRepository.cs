using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class CustomerCardRepository(AppDbContext context) : ICustomerCardRepository
{
    public async Task<IReadOnlyList<CustomerCard>> GetCustomerCardAsync()
    {
        return await context.CustomerCards.ToListAsync();
    }
}
