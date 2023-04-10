using BurgerMVC.BusinessLayer.Abstract;
using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DessertController : Controller
    {
        IDessertService _dessertService;

        public DessertController(IDessertService dessertService)
        {
            _dessertService = dessertService;
        }

        public IActionResult Index()
        {
            DessertViewModel model = new DessertViewModel()
            {
                Desserts = _dessertService.TGetList(),
                Dessert = new Dessert()
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult DessertAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DessertAdd(Dessert dessert)
        {
            if (dessert.UpdatedTime is null)
                dessert.UpdatedTime = dessert.CreatedTime;

            _dessertService.TAdd(dessert);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DessertUpdate(int id)
        {
            Dessert dessert = _dessertService.TGetByID(id);
            return PartialView(dessert);
        }

        [HttpPost]
        public IActionResult DessertUpdate(Dessert dessert)
        {
            dessert.UpdatedTime = DateTime.Now;
           
            _dessertService.TUpdate(dessert);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DessertDelete(int id)
        {
            var value = _dessertService.TGetByID(id);
            return PartialView(value);
        }

        [HttpPost]
        public IActionResult DessertDelete(Dessert dessert)
        {
            _dessertService.TDelete(dessert);
            return RedirectToAction("Index");
        }
    }
}
