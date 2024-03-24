using PokemonAPI.Models;

namespace PokemonAPI.Database;

public class SeedDatabase
{
    public static void Seed(PokemonContext context)
    {
        context.Database.EnsureCreated();
        
        if (!context.Pokemon.Any())
        {
            var firstGenerationPokemon = GetFirstGenerationPokemon();
            context.Pokemon.AddRange(firstGenerationPokemon);
            context.SaveChanges();
        }
    }

    private static IEnumerable<Pokemon> GetFirstGenerationPokemon()
    {
        var pokemonList = new List<Pokemon>
        {
            new Pokemon {Name = "Bulbasaur", Index = 1, Type = "Grass/Poison", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/1"},
            new Pokemon {Name = "Ivysaur", Index = 2, Type = "Grass/Poison", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/2"},
            new Pokemon {Name = "Venusaur", Index = 3, Type = "Grass/Poison", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/3"},
            new Pokemon {Name = "Charmander", Index = 4, Type = "Fire", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/4"},
            new Pokemon {Name = "Charmeleon", Index = 5, Type = "Fire", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/5"},
            new Pokemon {Name = "Charizard", Index = 6, Type = "Fire/Flying", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/6"},
            new Pokemon {Name = "Squirtle", Index = 7, Type = "Water", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/7"},
            new Pokemon {Name = "Wartortle", Index = 8, Type = "Water", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/8"},
            new Pokemon {Name = "Blastoise", Index = 9, Type = "Water", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/9"},
            new Pokemon {Name = "Caterpie", Index = 10, Type = "Bug", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/10"},
            new Pokemon {Name = "Metapod", Index = 11, Type = "Bug", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/11"},
            new Pokemon {Name = "Butterfree", Index = 12, Type = "Bug/Flying", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/12"},
            new Pokemon {Name = "Weedle", Index = 13, Type = "Bug/Poison", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/13"},
            new Pokemon {Name = "Kakuna", Index = 14, Type = "Bug/Poison", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/14"},
            new Pokemon {Name = "Beedrill", Index = 15, Type = "Bug/Poison", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/15"},
            new Pokemon {Name = "Pidgey", Index = 16, Type = "Normal/Flying", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/16"},
            new Pokemon {Name = "Pidgeotto", Index = 17, Type = "Normal/Flying", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/17"},
            new Pokemon {Name = "Pidgeot", Index = 18, Type = "Normal/Flying", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/18"},
            new Pokemon {Name = "Rattata", Index = 19, Type = "Normal", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/19"},
            new Pokemon {Name = "Raticate", Index = 20, Type = "Normal", SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/20"},
        };
        
        return pokemonList;
    }
}