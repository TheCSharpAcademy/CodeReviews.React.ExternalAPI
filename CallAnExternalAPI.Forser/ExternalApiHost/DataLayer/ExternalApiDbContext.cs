using ExternalApiHost.Models;
using Microsoft.EntityFrameworkCore;

namespace ExternalApiHost.DataLayer
{
    public class ExternalApiDbContext : DbContext
    {
        public DbSet<EnergyDrink> EnergyDrinks { get; set; }
        public ExternalApiDbContext(DbContextOptions<ExternalApiDbContext> options) : base(options) { }
    }
}