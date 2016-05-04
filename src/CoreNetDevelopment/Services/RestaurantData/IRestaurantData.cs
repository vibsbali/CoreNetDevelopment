using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreNetDevelopment.Models;

namespace CoreNetDevelopment.Services.RestaurantData
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Task<Restaurant> GetAsync(int id);
    }
}
