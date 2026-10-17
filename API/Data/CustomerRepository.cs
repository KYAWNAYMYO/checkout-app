using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class CustomerRepository(AppDbContext context) : ICustomerRepository
{
    public async Task<IReadOnlyList<Customer>> GetCustomerAsync()
    {
          return await context.Customers.ToListAsync();
    }
}

