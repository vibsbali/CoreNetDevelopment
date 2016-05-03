using CoreNetDevelopment.Models;
using Microsoft.AspNet.Mvc;

namespace CoreNetDevelopment.Controllers
{
    public class HomeController : Controller
    {
        public object Index()
        {
            var restaurant = new Restaurant {Id = 1, Name = "Sabatino's"};
            return View(restaurant);
        }
    }
}
