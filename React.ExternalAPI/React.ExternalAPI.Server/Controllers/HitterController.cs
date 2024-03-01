using Microsoft.AspNetCore.Mvc;
using React.ExternalAPI.Server.Models;

namespace React.ExternalAPI.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HitterController : ControllerBase
{
	private readonly HitterContext _context;

	public HitterController(HitterContext context)
	{
		_context = context;
	}

	[HttpGet]
	public ActionResult<IEnumerable<Hitter>> Get()
	{
		var hitters = _context.Hitters.ToList();
		return Ok(hitters);
	}
}
