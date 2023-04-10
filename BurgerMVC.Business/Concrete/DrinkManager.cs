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
    public class DrinkManager : IDrinkService
    {
        IDrinkDal _drinkDal;

        public DrinkManager(IDrinkDal drinkDal)
        {
            this._drinkDal = drinkDal;
        }

        public void TAdd(Drink t)
        {
           _drinkDal.Insert(t);
        }

        public void TDelete(Drink t)
        {
            _drinkDal.Delete(t);
        }

        public Drink TGetByID(int id)
        {
            return _drinkDal.GetByID(id);
        }

        public Drink TGetByID(Guid id)
        {
            return _drinkDal.GetByID(id);
        }

        public List<Drink> TGetList()
        {
            return _drinkDal.GetList();
        }

        public List<Drink> TGetListByFilter(Expression<Func<Drink, bool>> filter)
        {
            return _drinkDal.GetListByFilter(filter);
        }

        public void TUpdate(Drink t)
        {
            _drinkDal.Update(t);
        }
    }
}
