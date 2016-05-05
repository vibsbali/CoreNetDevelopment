using System.Threading.Tasks;
using CoreNetDevelopment.Models;
using Microsoft.AspNet.Mvc;
using CoreNetDevelopment.ViewModels;
using Microsoft.AspNet.Http.Features;
using Microsoft.AspNet.Identity;

namespace CoreNetDevelopment.Controllers
{
    public class Account : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public Account(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Login(string returnUrl)
        //{
            
        //}

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = vm.Username
                };
                var result = await userManager.CreateAsync(user, vm.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }

                foreach (var identityError in result.Errors)
                {
                    ModelState.AddModelError("", identityError.Description);
                }
            }
            return View();
        }
    }
}
