using System.Collections.Generic;
using System.Threading.Tasks;
using CoreNetDevelopment.Models;
using CoreNetDevelopment.Services.DataLayer;
using Microsoft.Data.Entity;

namespace CoreNetDevelopment.Services.RestaurantData
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext context;

        public SqlRestaurantData(OdeToFoodDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return context.Restaurants;
        }

        public Task<Restaurant> GetAsync(int id)
        {
            return context.Restaurants.FirstOrDefaultAsync(r => r.Id == id);
        }

        public Task<int> AddAsync(Restaurant restaurant)
        {
            context.Restaurants.Add(restaurant);
            return context.SaveChangesAsync();
        }

        public Task<int> Update(Restaurant restaurant)
        {
            context.Restaurants.Update(restaurant);
            return context.SaveChangesAsync();
        }
    }
}
