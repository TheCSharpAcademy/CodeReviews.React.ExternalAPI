using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wizards.Api.Data;
using Wizards.Api.Models;

namespace Wizards.Api.Controllers;

/// <summary>
/// The WizardsController class is responsible for handling API requests related to the 
/// management and retrieval of Wizard data. It provides endpoints for retrieving a list 
/// of wizards and individual wizard details from the database.
/// </summary>
/// <remarks>
/// This controller interacts with the WizardsDataContext to perform database operations, 
/// utilizing Entity Framework Core for data access. It supports the following operations:
/// <list type="bullet">
/// <item>
/// <description>GET: Retrieves all wizards ordered by name.</description>
/// </item>
/// <item>
/// <description>GET: Retrieves a specific wizard by its unique identifier (Guid).</description>
/// </item>
/// </list>
/// </remarks>
/// <example>
/// GET api/wizards - Retrieves a list of wizards.
/// GET api/wizards/{id} - Retrieves a specific wizard by ID.
/// </example>
[Route("api/[controller]")]
[ApiController]
public class WizardsController : ControllerBase
{
    #region Fields

    private readonly WizardsDataContext _context;

    #endregion
    #region Constructors

    public WizardsController(WizardsDataContext context)
    {
        _context = context;
    }

    #endregion
    #region Methods

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Wizard>>> GetWizard()
    {
        return await _context.Wizard.OrderBy(o => o.Name).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Wizard>> GetWizard(Guid id)
    {
        var wizard = await _context.Wizard.FindAsync(id);

        return wizard == null 
            ? NotFound() 
            : wizard;
    }

    #endregion
}
