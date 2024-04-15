using Microsoft.EntityFrameworkCore;
using PokemonAPI.Database;
using PokemonAPI.Models;

namespace PokemonAPI.Repositories;

public class PokemonRepository(PokemonContext pokemonContext) : IPokemonRepository
{
    public async Task<IEnumerable<Pokemon>> GetPokemon()
    {
        return await pokemonContext.Pokemon.ToListAsync();
    }

    public async Task<Pokemon?> GetPokemonById(int id)
    {
        return await pokemonContext.Pokemon.FindAsync(id);
    }
}