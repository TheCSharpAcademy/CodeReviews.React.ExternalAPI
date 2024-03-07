using Microsoft.EntityFrameworkCore;

namespace React.ExternalAPI.Server.Models;

public class HitterContext : DbContext
{
	public HitterContext(DbContextOptions<HitterContext> options) : base(options)
	{
	}

	public DbSet<Hitter> Hitters { get; set; }
}

