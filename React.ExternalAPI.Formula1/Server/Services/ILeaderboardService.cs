using Formula1.Api.DTOs;

namespace Formula1.Api.Services;

public interface ILeaderboardService
{
    public Task<List<LeaderboardEntryDTO>?> GetLeaderboardAsync();
}
