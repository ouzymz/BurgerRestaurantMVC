using BurgerMVC.DataLayer.Abstract;
using BurgerMVC.DataLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.DataLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T t)
        {
            using var c = new BurgerDbContext();
            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new BurgerDbContext();
            return c.Set<T>().Find(id);
        }

        public T GetByID(Guid id)
        {
            using var c = new BurgerDbContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new BurgerDbContext();
            return c.Set<T>().ToList();
        }

        public List<T> GetListByFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new BurgerDbContext();

            return c.Set<T>().Where(filter).ToList();
        }

        public void Insert(T t)
        {
            using var c = new BurgerDbContext();
            c.Add(t);
            c.SaveChanges();
        }
        public void Update(T t)
        {
            using var c = new BurgerDbContext();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
