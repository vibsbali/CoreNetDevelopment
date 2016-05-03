using CoreNetDevelopment.Services.RestaurantData;
using Microsoft.AspNet.Mvc;

namespace CoreNetDevelopment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }

        public object Index()
        {
            var restaurants = restaurantData.GetAll();
            return View(restaurants);
        }
    }
}
