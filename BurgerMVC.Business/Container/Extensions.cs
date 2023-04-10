using BurgerMVC.BusinessLayer.Abstract;
using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.Abstract;
using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDessertService, DessertManager>();
            services.AddScoped<IDessertDal, EfDessertDal>();

            services.AddScoped<IDrinkService, DrinkManager>();
            services.AddScoped<IDrinkDal, EfDrinkDal>();

            services.AddScoped<IExtraService, ExtraManager>();
            services.AddScoped<IExtraDal, EfExtraDal>();

            services.AddScoped<IMenuService, MenuManager>();
            services.AddScoped<IMenuDal, EfMenuDal>();

            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<IOrderDal, EfOrderDal>();

            services.AddScoped<ISauceService, SauceManager>();
            services.AddScoped<ISauceDal, EfSauceDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
        }
    }
}
