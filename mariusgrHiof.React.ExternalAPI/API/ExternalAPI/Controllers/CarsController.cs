using ExternalAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ExternalAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CarsController : ControllerBase
  {
    private readonly ICarRepository _carRepository;

    public CarsController(ICarRepository carRepository)
    {
      _carRepository = carRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllCars()
    {
      return Ok(await _carRepository.GetAllCarsAsync());
    }
  }
}
