using ExternalApiHost.DataLayer;
using ExternalApiHost.Models;

namespace ExternalApiHost.Repositories
{
    public class DrinkRepository : GenericRepository<EnergyDrink>, IDrinkRepository
    {
        private readonly ExternalApiDbContext _context;
        public DrinkRepository(ExternalApiDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
