using Microsoft.EntityFrameworkCore;
using Wizards.Api.Models;

namespace Wizards.Api.Data;

/// <summary>
/// Represents the Entity Framework Core database context for the Wizards data store.
/// </summary>
public class WizardsDataContext : DbContext
{
    #region Constructors

    public WizardsDataContext (DbContextOptions<WizardsDataContext> options) : base(options)
    {
    }

    #endregion
    #region Properties

    public DbSet<Wizard> Wizard { get; set; }

    #endregion
}
