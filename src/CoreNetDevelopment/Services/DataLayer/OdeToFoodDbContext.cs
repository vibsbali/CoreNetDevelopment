using CoreNetDevelopment.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace CoreNetDevelopment.Services.DataLayer
{
    public class OdeToFoodDbContext : IdentityDbContext<User>
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
