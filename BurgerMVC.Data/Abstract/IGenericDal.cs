using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.DataLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        T GetByID(int id);
        T GetByID(Guid id);
        List<T> GetList();
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);

    }
}
