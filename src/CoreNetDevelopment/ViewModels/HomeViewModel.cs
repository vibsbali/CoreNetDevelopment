using System.Collections.Generic;
using CoreNetDevelopment.Models;
using JetBrains.Annotations;

namespace CoreNetDevelopment.ViewModels
{
    public class HomeViewModel
    {
        public string CurrentGreeting { get; set; }
        public IEnumerable<Restaurant> Restaurants {[NotNull] get; set; }
    }
}
