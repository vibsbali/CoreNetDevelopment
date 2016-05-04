using System.ComponentModel.DataAnnotations;

namespace CoreNetDevelopment.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required][MaxLength(80)][MinLength(4)]
        [Display(Name="Restaurant Name")]
        public string Name { get; set; }
        public CuisineType CuisineType { get; set; }
    }
}
