using BurgerMVC.BusinessLayer.Abstract;
using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System.Security.Claims;

namespace BurgerMVCBoost.Controllers
{
    [Authorize(Roles = "Customer,Admin")]

    public class OrderController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        IAppUserService _AppUserService;
        IMenuService _menuService;
        IExtraService _extraService;
        IDessertService _dessertService;
        ISauceService _sauceService;
        IDrinkService _drinkService;
        IAppUserService _appUserService;
        IOrderService _orderService;
        public OrderController(IMenuService menuService, IExtraService extraService, IDessertService dessertService, ISauceService sauceService, IDrinkService drinkService, IAppUserService userService, UserManager<AppUser> userManager, IOrderService orderService, IAppUserService appUserService)
        {
            _menuService = menuService;
            _extraService = extraService;
            _dessertService = dessertService;
            _sauceService = sauceService;
            _drinkService = drinkService;
            _userManager = userManager;
            _AppUserService = userService;
            _AppUserService = appUserService;
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult OrderList()
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

        public IActionResult Order(int id)
        {
            AllMenuVM vm = new AllMenuVM()
            {
                Extras = _extraService.TGetList(),
                Desserts = _dessertService.TGetList(),
                Sauces = _sauceService.TGetList(),
                Menus = _menuService.TGetList(),
                Drinks = _drinkService.TGetList(),

            };
            vm.Menu = _menuService.TGetByID(id);
            return View(vm);
        }

        [HttpPost]
        public IActionResult AddToBasket(AllMenuVM model)
        {
            if (model.Dessert != null) { model.Desserts.Add(_dessertService.TGetByID(model.Dessert.ID)); }

            if (model.Drink != null) { model.Drinks.Add(_drinkService.TGetByID(model.Drink.ID)); }

            if (model.Menu != null) { model.Menus.Add(_menuService.TGetByID(model.Menu.ID)); }

            if (model.sauce != null) { model.Sauces.Add(_sauceService.TGetByID(model.sauce.ID)); }

            if (model.Extra != null) { model.Extras.Add(_extraService.TGetByID(model.Extra.ID)); }

            Order orderDetails = new Order()
            {
                Desserts = model.Desserts,
                Drinks = model.Drinks,
                Menus = model.Menus,
                Sauces = model.Sauces,
                Extras = model.Extras,
            };

            orderDetails.TotalPrice = orderDetails.Sauces.Sum(s => s.Price) +
                                      orderDetails.Desserts.Sum(s => s.Price) +
                                      orderDetails.Menus.Sum(s => s.Price) +
                                      orderDetails.Drinks.Sum(s => s.Price) +
                                      orderDetails.Extras.Sum(s => s.Price);

            HttpContext.Session.SetString("CurrentOrder", JsonConvert.SerializeObject(orderDetails));

            return View(orderDetails);
        }

        public IActionResult AddToBasket()
        {
            if (HttpContext.Session.TryGetValue("CurrentOrder", out byte[] basket))
            {
                var orderDetails = JsonConvert.DeserializeObject<Order>(HttpContext.Session.GetString("CurrentOrder"));

                return View(orderDetails);
            }
            else return RedirectToAction("OrderList");
        }

        public IActionResult OrderNow()
        {
            Order orderDetails = JsonConvert.DeserializeObject<Order>(HttpContext.Session.GetString("CurrentOrder"));

            var user = _AppUserService.TGetByID(new Guid(_userManager.GetUserId(User)));

            orderDetails.User = user;

            user.Orders.Add(orderDetails);

            _AppUserService.TUpdate(user);

            ViewData["result"] = orderDetails;

            return View("AddToBasket", ViewData["result"]);
        }
    }
}
