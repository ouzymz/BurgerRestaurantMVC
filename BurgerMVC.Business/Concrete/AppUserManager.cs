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
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TAdd(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetByID(int id)
        {
            return _appUserDal.GetByID(id);
        }
        public AppUser TGetByID(Guid id)
        {
            return _appUserDal.GetByID(id);
        }

        public List<AppUser> TGetList()
        {
            return _appUserDal.GetList();
        }

        public List<AppUser> TGetListByFilter(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppUser t)
        {
             _appUserDal.Update(t);
        }
    }
}
