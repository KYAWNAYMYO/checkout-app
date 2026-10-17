using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TransactionController(ITransactionRepository transactionRepository) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Transaction>>> GetUsers()
        {
            return Ok(await transactionRepository.GetTransactionAsync());
        }
    }
}
