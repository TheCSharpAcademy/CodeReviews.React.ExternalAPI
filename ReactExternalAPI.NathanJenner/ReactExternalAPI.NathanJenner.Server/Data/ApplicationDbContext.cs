using Microsoft.EntityFrameworkCore;
using ReactExternal.API.Models;

namespace ReactExternal.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<ImageModel> Images { get; set; }
}