using ExternalApiHost.Models;
using ExternalApiHost.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExternalApiHost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkController : ControllerBase
    {
        private IDrinkRepository _repository {  get; set; }

        public DrinkController(IDrinkRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("GetDrinks")]
        public async Task<IEnumerable<EnergyDrink>> GetDrinks() 
        { 
            return await _repository.GetAllAsync();
        }

        [HttpGet("GetDrink")]
        public async Task<EnergyDrink> GetDrink(int id) 
        {
            return await _repository.GetByIdAsync(id);
        }
    }
}