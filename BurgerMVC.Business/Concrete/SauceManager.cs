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
    public class SauceManager : ISauceService
    {
        ISauceDal _sauceDal;

        public SauceManager(ISauceDal sauceDal)
        {
            _sauceDal = sauceDal;
        }

        public void TAdd(Sauce t)
        {
            _sauceDal.Insert(t);
        }

        public void TDelete(Sauce t)
        {
            _sauceDal.Delete(t);
        }

        public Sauce TGetByID(int id)
        {
            return _sauceDal.GetByID(id);
        }

        public Sauce TGetByID(Guid id)
        {
            return _sauceDal.GetByID(id);
        }

        public List<Sauce> TGetList()
        {
            return _sauceDal.GetList();
        }

        public List<Sauce> TGetListByFilter(Expression<Func<Sauce, bool>> filter)
        {
            return _sauceDal.GetListByFilter(filter);
        }

        public void TUpdate(Sauce t)
        {
            _sauceDal.Update(t);
        }
    }
}
