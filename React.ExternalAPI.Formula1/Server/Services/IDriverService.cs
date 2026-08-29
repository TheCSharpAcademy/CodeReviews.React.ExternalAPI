using Formula1.Api.DTOs;

namespace Formula1.Api.Services;

public interface IDriverService
{
    public Task<List<DriverDTO>?> GetDriversAsync();
    public Task<DriverDTO?> GetDriverByNumberAsync(int number);
}
