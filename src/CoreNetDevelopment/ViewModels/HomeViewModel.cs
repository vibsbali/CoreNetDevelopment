using System.Collections.Generic;
using CoreNetDevelopment.Models;

namespace CoreNetDevelopment.ViewModels
{
    public class HomeViewModel
    {
        public string CurrentGreeting { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}
