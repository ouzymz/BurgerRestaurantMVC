using AutoMapper;
using BurgerMVC.BusinessLayer.Abstract;
using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Controllers
{
    public class MenuController : Controller
    {
        IMenuService _menuService;
        IExtraService _extraService;
        IDessertService _dessertService;
        ISauceService _sauceService;
        IDrinkService _drinkService;
        public MenuController(IMenuService menuService, IExtraService extraService, IDessertService dessertService, ISauceService sauceService, IDrinkService drinkService)
        {
            _menuService = menuService;
            _extraService = extraService;
            _dessertService = dessertService;
            _sauceService = sauceService;
            _drinkService = drinkService;
        }
        public IActionResult Menu()
        {
            AllMenuVM vm = new AllMenuVM()
            {
                Extras = _extraService.TGetList(),
                Desserts = _dessertService.TGetList(),
                Sauces = _sauceService.TGetList(),
                Menus = _menuService.TGetList(),
                Drinks = _drinkService.TGetList(),
            };
            return View(vm);
        }


    }
}
