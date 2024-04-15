using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using React.ExternalAPI.Server.Models;

namespace React.ExternalAPI.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HittersController : ControllerBase
{
	private readonly HitterContext _context;

	public HittersController(HitterContext context)
	{
		_context = context;
	}

	[HttpGet]
	public async Task<ActionResult<IEnumerable<Hitter>>> GetHitters()
	{
		var hitters = await _context.Hitters.ToListAsync();
		return Ok(hitters);
	}

	[HttpGet("{id}")]
	public async Task<ActionResult<Hitter>> GetHitterById(int id)
	{
		var hitter = await _context.Hitters.FirstOrDefaultAsync(hitter => hitter.Id == id);
		if (hitter == null) return NotFound();
		return Ok(hitter);
	}
}
