using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CoreNetDevelopment.Services.Greeting;
using Microsoft.AspNet.Mvc;

namespace CoreNetDevelopment.ViewComponents
{
    public class Greeting : ViewComponent
    {
        private readonly IGreeter greeter;

        public Greeting(IGreeter greeter)
        {
            this.greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = greeter.GetGreeting();
            return View("default", model);
        }
    }
}
