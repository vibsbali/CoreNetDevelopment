using Microsoft.AspNet.Mvc;

namespace CoreNetDevelopment.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Phone()
        {
            return Content("+1-555-555-555");
        }

        public IActionResult Country()
        {
            return Content("USA");
        }
    }
}
