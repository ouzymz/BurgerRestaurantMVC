using BurgerMVC.BusinessLayer.Abstract;
using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SauceController : Controller
    {
        ISauceService _sauceService;

        public SauceController(ISauceService sauceService)
        {
            _sauceService = sauceService;
        }

        public IActionResult Index()
        {
            SauceViewModel model = new SauceViewModel()
            {
                Sauces = _sauceService.TGetList(),
                Sauce = new Sauce()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult SauceAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SauceAdd(Sauce sauce)
        {
            if (sauce.UpdatedTime is null)
                sauce.UpdatedTime = sauce.CreatedTime;

            _sauceService.TAdd(sauce);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SauceUpdate(int id)
        {
            Sauce sauce = _sauceService.TGetByID(id);
            return PartialView(sauce);
        }

        [HttpPost]
        public IActionResult SauceUpdate(Sauce sauce)
        {
            sauce.UpdatedTime = DateTime.Now;
            _sauceService.TUpdate(sauce);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SauceDelete(int id)
        {
            var value = _sauceService.TGetByID(id);
            return PartialView(value);
        }

        [HttpPost]
        public IActionResult SauceDelete(Sauce sauce)
        {
            _sauceService.TDelete(sauce);
            return RedirectToAction("Index");
        }
    }
}
