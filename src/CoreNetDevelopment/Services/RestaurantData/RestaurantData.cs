using System.Collections.Generic;
using System.Linq;
using CoreNetDevelopment.Models;

namespace CoreNetDevelopment.Services.RestaurantData
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public static IEnumerable<Restaurant> Restaurants { get; set; }

        static InMemoryRestaurantData()
        {
            Restaurants = new List<Restaurant>
            {
                new Restaurant {Id = 1, Name = "Tersiguel's"},
                new Restaurant {Id = 2, Name = "LJ's and the Kat"},
                new Restaurant {Id = 3, Name = "King's Contrivance"}
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return Restaurants;
        }

        public Restaurant Get(int id)
        {
            return Restaurants.FirstOrDefault(i => i.Id == id);
        }
    }
}