using Microsoft.AspNet.Mvc;

namespace CoreNetDevelopment.Controllers
{
    [Route("company/[controller]")]
    public class AboutController : Controller
    {
        //Will act as default and also respond to phone 
        [Route("")][Route("phone")]
        public IActionResult Phone()
        {
            return Content("+1-555-555-555");
        }

        [Route("[action]")]
        public IActionResult Country()
        {
            return Content("USA");
        }
    }
}
