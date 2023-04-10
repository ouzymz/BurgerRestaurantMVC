using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
