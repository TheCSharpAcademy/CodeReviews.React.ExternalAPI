using Formula1.Api.Data;
using Formula1.Api.DTOs;
using Formula1.Api.Models;
using Formula1.Api.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Formula1.Api.Services;

public class DriverService : IDriverService
{
    private readonly AppDbContext _context;

    public DriverService(AppDbContext context){
        _context = context;
    }

    public async Task<List<DriverDTO>?> GetDriversAsync()
    {
        var result = await _context.Drivers
            .AsNoTracking()
            .ToListAsync();
        return DriverMappingExtensions.ToDto(result);
    }
    public async Task<DriverDTO?> GetDriverByNumberAsync(int number)
    {
        var result = await _context.Drivers
            .AsNoTracking()
            .Where(d => d.Number == number)
            .FirstOrDefaultAsync();
        return result?.ToDto();
    }
}