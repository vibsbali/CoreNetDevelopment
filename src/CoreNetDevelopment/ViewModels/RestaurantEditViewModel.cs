using System.ComponentModel.DataAnnotations;
using CoreNetDevelopment.Models;

namespace CoreNetDevelopment.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required][MaxLength(80)][MinLength(4)]
        public string Name { get; set; }
        public CuisineType CuisineType { get; set; }
    }
}
