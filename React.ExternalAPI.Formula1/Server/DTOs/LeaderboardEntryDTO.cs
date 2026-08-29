namespace Formula1.Api.DTOs;

public class LeaderboardEntryDTO
{
    public int Position { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Team { get; set; } = string.Empty;
    public int Number { get; set; }
    public double Points { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
}
