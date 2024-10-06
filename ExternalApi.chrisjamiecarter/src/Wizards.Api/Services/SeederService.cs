using Wizards.Api.Data;
using Wizards.Api.Models;

namespace Wizards.Api.Services;

/// <summary>
/// Provides methods to seed the database with initial data.
/// This service adds a defined set of default Wizard records.
/// </summary>
internal class SeederService : ISeederService
{
    #region Fields

    private static readonly Wizard[] _wizards =
    [
        new Wizard
        {
            Name = "Harry Potter",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/HarryPotter.png",
            Description = "The boy who lived. A wizard from the Harry Potter universe."
        },
        new Wizard
        {
            Name = "Gandalf the Grey",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/GandalfTheGrey.png",
            Description = "A wizard from the Lord of the Rings universe, known for his wisdom and power."
        },
        new Wizard
        {
            Name = "Merlin",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Merlin.png",
            Description = "A legendary wizard from Arthurian mythology, often depicted as King Arthur's advisor."
        },
        new Wizard
        {
            Name = "Albus Dumbledore",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/AlbusDumbledore.png",
            Description = "The headmaster of Hogwarts and one of the greatest wizards in the Harry Potter universe."
        },
        new Wizard
        {
            Name = "Doctor Strange",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/DoctorStrange.png",
            Description = "A master of the mystic arts from the Marvel universe."
        },
        new Wizard
        {
            Name = "Saruman",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Saruman.png",
            Description = "A powerful and once-wise wizard who turned to evil in the Lord of the Rings universe."
        },
        new Wizard
        {
            Name = "Morgana Le Fay",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/MorganaLeFay.png",
            Description = "A powerful sorceress from Arthurian legend, often depicted as an antagonist to Merlin."
        },
        new Wizard
        {
            Name = "Rincewind",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Rincewind.png",
            Description = "A bumbling wizard from Terry Pratchett's Discworld series."
        },
        new Wizard
        {
            Name = "Elminster Aumar",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/ElminsterAumar.png",
            Description = "A legendary wizard from the Forgotten Realms universe, created by Dungeons & Dragons."
        },
        new Wizard
        {
            Name = "Raistlin Majere",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/RaistlinMajere.png",
            Description = "A dark wizard from the Dragonlance universe, known for his immense power and ambition."
        },
        new Wizard
        {
            Name = "The Wizard of Oz",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/TheWizardOfOz.png",
            Description = "The mysterious and supposedly all-powerful wizard from the Land of Oz."
        },
        new Wizard
        {
            Name = "Zatanna Zatara",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/ZatannaZatara.png",
            Description = "A magician and superhero from DC Comics who casts spells by speaking backwards."
        },
        new Wizard
        {
            Name = "Prospero",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Prospero.png",
            Description = "The protagonist of Shakespeare's play 'The Tempest', known for his magical abilities."
        },
        new Wizard
        {
            Name = "Mordenkainen",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Mordenkainen.png",
            Description = "A powerful wizard from Dungeons & Dragons lore, known for his neutrality and mastery of magic."
        },
        new Wizard
        {
            Name = "Tim the Enchanter",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/TimTheEnchanter.png",
            Description = "A comedic wizard from Monty Python and the Holy Grail."
        },
        new Wizard
        {
            Name = "Jafar",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Jafar.png",
            Description = "The royal vizier and sorcerer from Disney's Aladdin."
        },
        new Wizard
        {
            Name = "The Ancient One",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/TheAncientOne.png",
            Description = "The mentor of Doctor Strange and the previous Sorcerer Supreme in the Marvel universe."
        },
        new Wizard
        {
            Name = "Orko",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Orko.png",
            Description = "A clumsy yet lovable wizard from the Masters of the Universe series."
        },
        new Wizard
        {
            Name = "Ged (Sparrowhawk)",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/GedSparrowhawk.png",
            Description = "The protagonist of Ursula K. Le Guin's Earthsea series, a powerful mage."
        },
        new Wizard
        {
            Name = "Yennefer",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Yennefer.png",
            Description = "A sorceress from The Witcher universe, known for her intelligence and magical prowess."
        },
        new Wizard
        {
            Name = "Karsus",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Karsus.png",
            Description = "A powerful wizard from the Forgotten Realms universe, known for his failed attempt to ascend to godhood."
        },
        new Wizard
        {
            Name = "Medivh",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Medivh.png",
            Description = "A legendary wizard from the Warcraft universe, known as the Last Guardian."
        },
        new Wizard
        {
            Name = "Rita Repulsa",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/RitaRepulsa.png",
            Description = "An evil sorceress and villain from the Power Rangers series."
        },
        new Wizard
        {
            Name = "Wong",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Wong.png",
            Description = "The current Sorcerer Supreme and companion of Doctor Strange in the Marvel universe."
        },
        new Wizard
        {
            Name = "Voldemort",
            ImageUrl = "https://chrisjamiecarter.github.io/wizards/img/Voldemort.png",
            Description = "The dark lord and antagonist from the Harry Potter universe, known for his quest for immortality."
        }
    ];

    private readonly WizardsDataContext _context;

    #endregion
    #region Constructors

    public SeederService(WizardsDataContext context)
    {
        _context = context;
    }

    #endregion
    #region Methods

    public void SeedDatabase()
    {
        SeedWizards();
    }

    private void SeedWizards()
    {
        if (_context.Wizard.Any())
        {
            return;
        }

        foreach (var wizard in _wizards)
        {
            _context.Wizard.Add(wizard);

        }
        _context.SaveChanges();
    }

    #endregion
}
