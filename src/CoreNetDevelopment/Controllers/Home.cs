﻿using System.Threading.Tasks;
using CoreNetDevelopment.Services.Greeting;
using CoreNetDevelopment.Services.RestaurantData;
using CoreNetDevelopment.ViewModels;
using Microsoft.AspNet.Mvc;

namespace CoreNetDevelopment.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData restaurantData;
        private readonly IGreeter greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            this.restaurantData = restaurantData;
            this.greeter = greeter;
        }

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

        public ActionResult Create()
        {
            return View();
        }

    }
}
