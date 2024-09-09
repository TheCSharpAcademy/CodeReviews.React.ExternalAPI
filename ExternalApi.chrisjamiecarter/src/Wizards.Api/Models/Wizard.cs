namespace Wizards.Api.Models;

/// <summary>
/// Represents a Wizard entity.
/// </summary>
public class Wizard
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }
}
