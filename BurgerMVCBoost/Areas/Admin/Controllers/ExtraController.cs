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
    public class ExtraController : Controller
    {
        IExtraService _extraService;

        public ExtraController(IExtraService extraService)
        {
            _extraService = extraService;
        }

        public IActionResult Index()
        {
            ExtraViewModel model = new ExtraViewModel()
            {
                Extras = _extraService.TGetList(),
                Extra = new Extra()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult ExtraAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ExtraAdd(Extra extra)
        {
            if (extra.UpdatedTime is null)
                extra.UpdatedTime = extra.CreatedTime;

            _extraService.TAdd(extra);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ExtraUpdate(int id)
        {
            Extra extra = _extraService.TGetByID(id);
            return PartialView(extra);
        }

        [HttpPost]
        public IActionResult ExtraUpdate(Extra extra)
        {
            extra.UpdatedTime = DateTime.Now;
            _extraService.TUpdate(extra);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ExtraDelete(int id)
        {
            var value = _extraService.TGetByID(id);
            return PartialView(value);
        }

        [HttpPost]
        public IActionResult ExtraDelete(Extra extra)
        {
            _extraService.TDelete(extra);
            return RedirectToAction("Index");
        }
    }
}
