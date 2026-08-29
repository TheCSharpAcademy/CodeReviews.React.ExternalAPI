using Formula1.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Formula1.Api.Controllers;

[ApiController]
[Route("api/drivers")]
public class DriverController : ControllerBase
{
    private readonly IDriverService _driverService;

    public DriverController(IDriverService driverService)
    {
        _driverService = driverService;
    }

    [HttpGet]
    public async Task<IActionResult> GetDriversAsync()
    {
        var result = await _driverService.GetDriversAsync();
        return Ok(result);
    }

    [HttpGet("{number}")]
    public async Task<IActionResult> GetDriverByNameAsync(int number)
    {
        var result = await _driverService.GetDriverByNumberAsync(number);

        if (result == null)
            return NotFound();

        return Ok(result);
    }
}