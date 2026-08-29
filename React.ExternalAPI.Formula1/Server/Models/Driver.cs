using System.ComponentModel.DataAnnotations;

namespace Formula1.Api.Models;

public class Driver
{
    [Key]
    public Guid Id { get; set; }

    [MaxLength(100)]
    [Required]
    public string Name { get; set; } = string.Empty;

    [MaxLength(100)]
    [Required]
    public string Team { get; set; } = string.Empty;

    [Required]
    public int Number {  get; set; }

    public int Age { get; set; }

    public string Nationality { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;
}