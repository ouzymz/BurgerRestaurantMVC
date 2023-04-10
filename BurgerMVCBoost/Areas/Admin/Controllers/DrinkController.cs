using BurgerMVC.BusinessLayer.Abstract;
using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DrinkController : Controller
    {
       IDrinkService _drinkService;

        public DrinkController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        public IActionResult Index()
        {
            DrinkViewModel model = new DrinkViewModel()
            {
                Drinks = _drinkService.TGetList(),
                Drink = new Drink()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult DrinkAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DrinkAdd(Drink drink)
        {
            if (drink.UpdatedTime is null)
                drink.UpdatedTime = drink.CreatedTime;

            _drinkService.TAdd(drink);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DrinkUpdate(int id)
        {
            Drink drink = _drinkService.TGetByID(id);
            return PartialView(drink);
        }

        [HttpPost]
        public IActionResult DrinkUpdate(Drink drink)
        {
            drink.UpdatedTime = DateTime.Now;
            
            _drinkService.TUpdate(drink);
           
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DrinkDelete(int id)
        {
            var value = _drinkService.TGetByID(id);
            return PartialView(value);
        }

        [HttpPost]
        public IActionResult DrinkDelete(Drink drink)
        {
            _drinkService.TDelete(drink);
            return RedirectToAction("Index");
        }
    }
}
