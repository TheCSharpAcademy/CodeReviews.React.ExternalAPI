using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ReactApp1.Server.Models;
namespace ReactApp1.Server.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Place> Places { get; set; }
    }
}
