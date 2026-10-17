using API.Entities;

namespace API.Interfaces;

public interface ITransactionRepository
{
    Task<IReadOnlyList<Transaction>> GetTransactionAsync();

    Task<Transaction> Save(Transaction transaction);

    void Update(Transaction transaction);
}
