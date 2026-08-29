using Formula1.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Formula1.Api.Data;

public class DbInitializer
{
    public static async Task SeedAsync(AppDbContext context)
    {
        await context.Database.MigrateAsync();

        if (await context.Drivers.AnyAsync())
            return;

        var drivers = new List<Driver>
        {
            new() {Name = "Pierre Gasly", Team = "Alpine", Number = 10, Age = 30, Nationality = "French", ImageUrl = "/images/drivers/Gasly.avif"},
            new() {Name = "Franco Colapinto", Team = "Alpine", Number = 43, Age = 23, Nationality = "Argentinian", ImageUrl = "/images/drivers/Colapinto.avif"},

            new() {Name = "Fernando Alonso", Team = "Aston Martin", Number = 14, Age = 45, Nationality = "Spanish", ImageUrl = "/images/drivers/Alonso.avif"},
            new() {Name = "Lance Stroll", Team = "Aston Martin", Number = 18, Age = 27, Nationality = "Canadian", ImageUrl = "/images/drivers/Stroll.avif"},

            new() {Name = "Gabriel Bortoleto", Team = "Audi", Number = 5, Age = 21, Nationality = "Brazilian", ImageUrl = "/images/drivers/Bortoleto.avif"},
            new() {Name = "Nico Hulkenberg", Team = "Audi", Number = 27, Age = 39, Nationality = "German", ImageUrl = "/images/drivers/Hulkenberg.avif"},

            new() {Name = "Sergio Perez", Team = "Cadillac", Number = 11, Age = 36, Nationality = "Mexican", ImageUrl = "/images/drivers/Perez.avif"},
            new() {Name = "Valtteri Bottas", Team = "Cadillac", Number = 77, Age = 36, Nationality = "Finnish", ImageUrl = "/images/drivers/Bottas.avif"},

            new() {Name = "Charles Leclerc", Team = "Ferrari", Number = 16, Age = 28, Nationality = "Monegasque", ImageUrl = "/images/drivers/Leclerc.avif"},
            new() {Name = "Lewis Hamilton", Team = "Ferrari", Number = 44, Age = 41, Nationality = "British", ImageUrl = "/images/drivers/Hamilton.avif"},

            new() {Name = "Esteban Ocon", Team = "Haas", Number = 31, Age = 29, Nationality = "French", ImageUrl = "/images/drivers/Ocon.avif"},
            new() {Name = "Oliver Bearman", Team = "Haas", Number = 87, Age = 21, Nationality = "British", ImageUrl = "/images/drivers/Bearman.avif"},

            new() {Name = "Lando Norris", Team = "McLaren", Number = 1, Age = 26, Nationality = "British", ImageUrl = "/images/drivers/Norris.avif"},
            new() {Name = "Oscar Piastri", Team = "McLaren", Number = 81, Age = 25, Nationality = "Australian", ImageUrl = "/images/drivers/Piastri.avif"},

            new() {Name = "Andrea Kimi Antonelli", Team = "Mercedes", Number = 12, Age = 19, Nationality = "Italian", ImageUrl = "/images/drivers/Antonelli.avif"},
            new() {Name = "George Russell", Team = "Mercedes", Number = 63, Age = 28, Nationality = "British", ImageUrl = "/images/drivers/Russell.avif"},

            new() {Name = "Liam Lawson", Team = "Racing Bulls", Number = 30, Age = 24, Nationality = "New Zealander", ImageUrl = "/images/drivers/Lawson.avif"},
            new() {Name = "Arvid Lindblad", Team = "Racing Bulls", Number = 41, Age = 19, Nationality = "British", ImageUrl = "/images/drivers/Lindblad.avif"},

            new() {Name = "Max Verstappen", Team = "Red Bull Racing", Number = 3, Age = 28, Nationality = "Dutch", ImageUrl = "/images/drivers/Verstappen.avif"},
            new() {Name = "Isack Hadjar", Team = "Red Bull Racing", Number = 6, Age = 21, Nationality = "French", ImageUrl = "/images/drivers/Hadjar.avif"},

            new() {Name = "Alex Albon", Team = "Williams", Number = 23, Age = 30, Nationality = "Thai", ImageUrl = "/images/drivers/Albon.avif"},
            new() {Name = "Carlos Sainz", Team = "Williams", Number = 55, Age = 31, Nationality = "Spanish", ImageUrl = "/images/drivers/Sainz.avif"}
        };

        await context.Drivers.AddRangeAsync(drivers);
        await context.SaveChangesAsync();
    }
}
