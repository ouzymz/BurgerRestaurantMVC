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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TAdd(Order t)
        {
            _orderDal.Insert(t);
        }

        public void TDelete(Order t)
        {
            _orderDal.Delete(t);
        }

        public Order TGetByID(int id)
        {
            return _orderDal.GetByID(id);
        }

        public Order TGetByID(Guid id)
        {
            return _orderDal.GetByID(id);
        }

        public List<Order> TGetList()
        {
            return _orderDal.GetList();
        }

        public List<Order> TGetListByFilter(Expression<Func<Order, bool>> filter)
        {
            return _orderDal.GetListByFilter(filter);
        }

        public void TUpdate(Order t)
        {
            _orderDal.Update(t);
        }
    }
}
