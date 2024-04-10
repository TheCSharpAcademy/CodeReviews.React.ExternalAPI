using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Models;
using PokemonAPI.Repositories;

namespace PokemonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController(IPokemonRepository pokemonRepository) : ControllerBase
    {
        // GET: api/Pokemon
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pokemon>>> GetPokemon()
        {
            var pokemon = await pokemonRepository.GetPokemon();
            return Ok(pokemon);
        }

        // GET: api/Pokemon/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pokemon>> GetPokemon(int id)
        {
            var pokemon = await pokemonRepository.GetPokemonById(id);

            if (pokemon == null)
            {
                return NotFound();
            }

            return Ok(pokemon);
        }
    }
}
