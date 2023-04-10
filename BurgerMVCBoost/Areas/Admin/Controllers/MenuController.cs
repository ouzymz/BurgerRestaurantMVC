using BurgerMVC.BusinessLayer.Abstract;
using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public IActionResult Index()
        {
            MenuViewModel model = new MenuViewModel()
            {
                Menus = _menuService.TGetList(),
                Menu = new Menu()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult MenuAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MenuAdd(Menu menu)
        {
            _menuService.TAdd(menu);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MenuUpdate(int id)
        {
            Menu menu = _menuService.TGetByID(id);
            return PartialView(menu);
        }

        [HttpPost]
        public IActionResult MenuUpdate(Menu menu)
        {
            menu.UpdatedTime = DateTime.Now;
            _menuService.TUpdate(menu);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MenuDelete(int id)
        {
            var value = _menuService.TGetByID(id);
            return PartialView(value);
        }

        [HttpPost]
        public IActionResult MenuDelete(Menu menu)
        {
            _menuService.TDelete(menu);
            return RedirectToAction("Index");
        }
    }
}
