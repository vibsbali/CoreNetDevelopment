using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreNetDevelopment.Models;

namespace CoreNetDevelopment.Services.RestaurantData
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        public List<Restaurant> Restaurants { get; set; }

        public InMemoryRestaurantData()
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

        public Task<Restaurant> GetAsync(int id)
        {
            return Task.Run(
                () => {
                return Restaurants.FirstOrDefault(i => i.Id == id);
            });
        }

        public Task<int> AddAsync(Restaurant restaurant)
        {
            return Task.Run(() =>
            {
                restaurant.Id = Restaurants.Max(r => r.Id) + 1;
                Restaurants.Add(restaurant);
                return 1;
            });
        }

        public Task<int> Update(Restaurant restaurant)
        {
            throw new System.NotImplementedException();
        }
    }
}