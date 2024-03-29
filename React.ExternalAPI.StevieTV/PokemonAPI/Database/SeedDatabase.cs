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
            new Pokemon
            {
                Name = "Bulbasaur",
                Index = 1,
                Type = "Grass/Poison",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/1.png",
                Description = "A strange seed was planted on its back at birth. The plant sprouts and grows with this Pokémon."
            },
            new Pokemon
            {
                Name = "Ivysaur",
                Index = 2,
                Type = "Grass/Poison",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/2.png",
                Description = "When the bulb on its back grows large, it appears to lose the ability to stand on its hind legs."
            },
            new Pokemon
            {
                Name = "Venusaur",
                Index = 3,
                Type = "Grass/Poison",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/3.png",
                Description = "The plant blooms when it is absorbing solar energy. It stays on the move to seek sunlight."
            },
            new Pokemon
            {
                Name = "Charmander",
                Index = 4,
                Type = "Fire",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/4.png",
                Description = "Obviously prefers hot places. When it rains, steam is said to spout from the tip of its tail."
            },
            new Pokemon
            {
                Name = "Charmeleon",
                Index = 5,
                Type = "Fire",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/5.png",
                Description = "When it swings its burning tail, it elevates the temperature to unbearably high levels."
            },
            new Pokemon
            {
                Name = "Charizard",
                Index = 6,
                Type = "Fire/Flying",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/6.png",
                Description = "Spits fire that is hot enough to melt boulders. Known to cause forest fires unintentionally."
            },
            new Pokemon
            {
                Name = "Squirtle",
                Index = 7,
                Type = "Water",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/7.png",
                Description = "After birth, its back swells and hardens into a shell. Powerfully sprays foam from its mouth."
            },
            new Pokemon
            {
                Name = "Wartortle",
                Index = 8,
                Type = "Water",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/8.png",
                Description = "Often hides in water to stalk unwary prey. For swimming fast, it moves its ears to maintain balance."
            },
            new Pokemon
            {
                Name = "Blastoise",
                Index = 9,
                Type = "Water",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/9.png",
                Description = "Once it takes aim at its enemy, it blasts out water with even more force than a fire hose."
            },
            new Pokemon
            {
                Name = "Caterpie",
                Index = 10,
                Type = "Bug",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/10.png",
                Description = "Its short feet are tipped with suction pads that enable it to tirelessly climb slopes and walls."
            },
            new Pokemon
            {
                Name = "Metapod",
                Index = 11,
                Type = "Bug",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/11.png",
                Description = "This is its pre-evolved form. At this stage, it can only harden, so it remains motionless to avoid attack."
            },
            new Pokemon
            {
                Name = "Butterfree",
                Index = 12,
                Type = "Bug/Flying",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/12.png",
                Description = "In battle, it flaps its wings at great speed to release highly toxic dust into the air."
            },
            new Pokemon
            {
                Name = "Weedle",
                Index = 13,
                Type = "Bug/Poison",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/13.png",
                Description = "Often found in forests and grasslands. It has a sharp, toxic barb of around two inches on top of its head."
            },
            new Pokemon
            {
                Name = "Kakuna",
                Index = 14,
                Type = "Bug/Poison",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/14.png",
                Description = "Able to move only slightly. When endangered, it may stick out its stinger and poison its enemy."
            },
            new Pokemon
            {
                Name = "Beedrill",
                Index = 15,
                Type = "Bug/Poison",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/15.png",
                Description = "Flies at high speed and attacks using its large venomous stingers on its forelegs and tail."
            },
            new Pokemon
            {
                Name = "Pidgey",
                Index = 16,
                Type = "Normal/Flying",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/16.png",
                Description = "It usually hides in tall grass. Because it dislikes fighting, it protects itself by kicking up sand."
            },
            new Pokemon
            {
                Name = "Pidgeotto",
                Index = 17,
                Type = "Normal/Flying",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/17.png",
                Description = "Very protective of its sprawling territorial area, this Pokémon will fiercely peck at any intruder."
            },
            new Pokemon
            {
                Name = "Pidgeot",
                Index = 18,
                Type = "Normal/Flying",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/18.png",
                Description = "When hunting, it skims the surface of water at high speed to pick off unwary prey such as Magikarp."
            },
            new Pokemon
            {
                Name = "Rattata",
                Index = 19,
                Type = "Normal",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/19.png",
                Description = "Bites anything when it attacks. Small and very quick, it is a common sight in many places."
            },
            new Pokemon
            {
                Name = "Raticate",
                Index = 20,
                Type = "Normal",
                SpriteUrl = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/versions/generation-i/red-blue/transparent/20.png",
                Description = "It uses its whiskers to maintain its balance. It apparently slows down if they are cut off."
            },
        };

        return pokemonList;
    }
}