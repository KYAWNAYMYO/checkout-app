using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class TransactionRepository(AppDbContext context) : ITransactionRepository
{
    public async Task<IReadOnlyList<Transaction>> GetTransactionAsync()
    {
        return await context.Transactions.ToListAsync();
    }

    public Task<Transaction> Save(Transaction transaction)
    {
        throw new NotImplementedException();
    }

    public void Update(Transaction transaction)
    {
        throw new NotImplementedException();
    }
}
