using Microsoft.EntityFrameworkCore;
using PokemonAPI.Models;

namespace PokemonAPI.Database;

public class PokemonContext(DbContextOptions<PokemonContext> options) : DbContext(options)
{
    public DbSet<Pokemon> Pokemon { get; set; } 
}