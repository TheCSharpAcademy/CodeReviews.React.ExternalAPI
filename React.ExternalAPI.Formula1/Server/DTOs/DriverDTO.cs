namespace Formula1.Api.DTOs;

public class DriverDTO
{
    public string Name { get; set; } = string.Empty;
    public string Team { get; set; } = string.Empty;
    public int Number { get; set; }
    public int Age { get; set; }
    public string Nationality { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
}

