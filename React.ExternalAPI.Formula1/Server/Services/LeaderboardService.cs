using Formula1.Api.Data;
using Formula1.Api.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Formula1.Api.Services;

public class LeaderboardService : ILeaderboardService
{
    private readonly AppDbContext _context;
    private readonly HttpClient _client;

    public LeaderboardService(AppDbContext context, HttpClient httpClient)
    {
        _context = context;
        _client = httpClient;
    }

    public async Task<List<LeaderboardEntryDTO>?> GetLeaderboardAsync()
    {
        var json = await _client.GetStringAsync("");

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var driverPoints = JsonSerializer.Deserialize<List<DriverPoint>>(json, options)?
            .Where(dp => dp.Number != 22)
            .ToList();

        if (driverPoints == null || driverPoints.Count == 0)
            return null;

        var driverNumbers = driverPoints.Select(dp => dp.Number).ToList();

        var drivers = await _context.Drivers
            .AsNoTracking()
            .Where(d => driverNumbers.Contains(d.Number))
            .ToListAsync();

        var driverLookup = drivers.ToDictionary(d => d.Number);

        var leaderboard = driverPoints
            .OrderBy(dp => dp.Position)
            .Select((dp, index) =>
            {
                driverLookup.TryGetValue(dp.Number, out var driver);

                return new LeaderboardEntryDTO
                {
                    Position = index + 1,
                    Name = driver?.Name ?? $"Driver #{dp.Number}",
                    Team = driver?.Team ?? "Unknown",
                    Number = dp.Number,
                    Points = dp.Point,
                    ImageUrl = driver?.ImageUrl ?? string.Empty
                };
            })
            .ToList();

        return leaderboard;
    }
}
