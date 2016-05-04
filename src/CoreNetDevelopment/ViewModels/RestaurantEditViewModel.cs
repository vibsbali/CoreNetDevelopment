using System.ComponentModel.DataAnnotations;
using CoreNetDevelopment.Models;

namespace CoreNetDevelopment.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required]
        public string Name { get; set; }
        public CuisineType CuisineType { get; set; }
    }
}
