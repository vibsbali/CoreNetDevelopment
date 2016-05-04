using CoreNetDevelopment.Models;
using Microsoft.Data.Entity;

namespace CoreNetDevelopment.Services.DataLayer
{
    public class OdeToFoodDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
