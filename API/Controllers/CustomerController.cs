using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    public class CustomerController(ICustomerRepository customerRepository) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<Customer>>> GetUsers()
        {
            return Ok(await customerRepository.GetCustomerAsync());
        }
    }
}
