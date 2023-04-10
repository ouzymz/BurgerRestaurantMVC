using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404(int code)
        {
            return View();
        }
    }
}
