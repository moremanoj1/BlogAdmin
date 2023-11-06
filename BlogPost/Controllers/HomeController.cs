using Microsoft.AspNetCore.Mvc;

namespace BlogPost.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult HomePage()
        {
            return View("~/Views/Home/HomePage.cshtml");
        }

    }
}
