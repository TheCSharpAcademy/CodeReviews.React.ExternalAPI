using ExternalAPI.Data;
using ExternalAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExternalAPI.Repository;

public class CarRepository : ICarRepository
{
  private readonly CarContext _context;

  public CarRepository(CarContext context)
  {
    _context = context;
  }
  public async Task<IEnumerable<Car>> GetAllCarsAsync()
  {
    return await _context.Cars.ToListAsync();
  }
}
