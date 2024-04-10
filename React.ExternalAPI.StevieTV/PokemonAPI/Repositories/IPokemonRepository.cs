using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Models;

namespace PokemonAPI.Repositories;

public interface IPokemonRepository
{
    Task<IEnumerable<Pokemon>> GetPokemon();
    Task<Pokemon?> GetPokemonById(int id);
}