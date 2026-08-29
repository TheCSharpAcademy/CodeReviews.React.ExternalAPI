using Formula1.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Formula1.Api.Controllers;

[ApiController]
[Route("api/leaderboard")]
public class LeaderboardController : ControllerBase
{
    private readonly ILeaderboardService _leaderboardService;

    public LeaderboardController(ILeaderboardService leaderboardService)
    {
        _leaderboardService = leaderboardService;
    }

    [HttpGet]
    public async Task<IActionResult> GetLeaderboardAsync()
    {
        var result = await _leaderboardService.GetLeaderboardAsync();

        if(result == null)
        {
            return NotFound();
        }
        return Ok(result);
    }
}
