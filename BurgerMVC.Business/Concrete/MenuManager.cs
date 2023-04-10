using BurgerMVC.BusinessLayer.Abstract;
using BurgerMVC.DataLayer.Abstract;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.BusinessLayer.Concrete
{
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;

        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }

        public void TAdd(Menu t)
        {
            _menuDal.Insert(t);
        }

        public void TDelete(Menu t)
        {
            _menuDal.Delete(t);
        }

        public Menu TGetByID(int id)
        {
            return _menuDal.GetByID(id);
        }

        public Menu TGetByID(Guid id)
        {
            return _menuDal.GetByID(id);
        }

        public List<Menu> TGetList()
        {
            return _menuDal.GetList();
        }

        public List<Menu> TGetListByFilter(Expression<Func<Menu, bool>> filter)
        {
            return _menuDal.GetListByFilter(filter);
        }

        public void TUpdate(Menu t)
        {
            _menuDal.Update(t);
        }

        public void StatusFalse(Menu t)
        {
            t.Status = false;
        }
    }
}
