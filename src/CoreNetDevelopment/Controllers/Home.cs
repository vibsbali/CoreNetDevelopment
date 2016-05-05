using System.Threading.Tasks;
using CoreNetDevelopment.Models;
using CoreNetDevelopment.Services.Greeting;
using CoreNetDevelopment.Services.RestaurantData;
using CoreNetDevelopment.ViewModels;
using JetBrains.Annotations;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace CoreNetDevelopment.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IRestaurantData restaurantData;
        private readonly IGreeter greeter;

        public HomeController([NotNull]IRestaurantData restaurantData,[NotNull] IGreeter greeter)
        {
            this.restaurantData = restaurantData;
            this.greeter = greeter;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            var restaurants = restaurantData.GetAll();
            var greeting = greeter.GetGreeting();

            var model = new HomeViewModel
            {
                CurrentGreeting = greeting,
                Restaurants = restaurants
            };
            return View(model);
        }

        public async Task<ActionResult> Details(int id)
        {
            var model = await restaurantData.GetAsync(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var restaurant = new Restaurant
                {
                    Name = model.Name,
                    CuisineType = model.CuisineType
                };

                var result = await restaurantData.AddAsync(restaurant);
                if (result > 0)
                {
                    return RedirectToAction("Details", "Home", new {id = restaurant.Id});
                }
            }
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = await restaurantData.GetAsync(id);
            if (model == null)
            {
                RedirectToAction("Index");
            }

            return View(model);
        }


        [HttpPost]
        public async Task<ActionResult> Edit(int id, [NotNull]RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var restaurant = await restaurantData.GetAsync(id);

                restaurant.Name = model.Name;
                restaurant.CuisineType = model.CuisineType;

                var result = await restaurantData.Update(restaurant);
                if (result > 0)
                {
                    return RedirectToAction("Details", "Home", new { id = restaurant.Id });
                }
            }
            return View();
        }
    }
}
