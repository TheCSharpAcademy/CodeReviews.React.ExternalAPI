namespace ExternalAPI.Models;

public class Car
{
  public int Id { get; set; }
  public string Make { get; set; } = string.Empty;
  public string Model { get; set; } = string.Empty;
  public int Hp { get; set; }
  public int YearOfRelease { get; set; }
  public string ImageUrl { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
  public string WikiLink { get; set; } = string.Empty;
}
