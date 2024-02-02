using ExternalAPI.Models;

namespace ExternalAPI.Repository;

public interface ICarRepository
{
  Task<IEnumerable<Car>> GetAllCarsAsync();
}
