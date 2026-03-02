using System.ComponentModel.DataAnnotations;

namespace ReactExternal.API.Models;

public class ImageModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Display (Name = "Image title")]
    [StringLength(50, MinimumLength = 1)]
    public string Title { get; set; }

    [Required]
    [Display(Name = "Image description")]
    [StringLength(50, MinimumLength = 1)]
    public string Description { get; set; }

    [Required]
    public string ImageUrl { get; set; }

    [Required]
    [Display(Name = "Author name")]
    [StringLength(50, MinimumLength = 1)]
    public string Author { get; set; }
}
