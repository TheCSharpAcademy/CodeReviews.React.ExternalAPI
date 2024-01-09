using System.ComponentModel.DataAnnotations;

namespace ExternalApiHost.Models
{
    public class EnergyDrink
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; }
        public int CanSize { get; set; }
        public string ImageUrl { get; set; }
    }
}