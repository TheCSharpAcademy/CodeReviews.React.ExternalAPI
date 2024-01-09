using ExternalApiHost.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace ExternalApiHost.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ExternalApiDbContext _context;
        private readonly DbSet<T> _entities;

        public GenericRepository(ExternalApiDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _entities.ToListAsync();

        public async Task<T> GetByIdAsync(int id) => await _entities.FindAsync(id);
    }
}