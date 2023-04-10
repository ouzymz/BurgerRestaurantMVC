using BurgerMVC.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderID { get; set; }
        public string? OrderName { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedTime { get; set; }
        public OrderStatus Status { get; set; }

        //Nav Prop

        public Guid UserID { get; set; }
        public virtual AppUser User { get; set; }

        public ICollection<Drink> Drinks { get; set; }
        public ICollection<Dessert> Desserts { get; set; }
        public ICollection<Menu> Menus { get; set; }
        public ICollection<Extra> Extras { get; set; }
        public ICollection<Sauce> Sauces { get; set; }


        public Order()
        {
            Drinks = new HashSet<Drink>();
            Desserts = new HashSet<Dessert>();
            Menus = new HashSet<Menu>();
            Extras = new HashSet<Extra>();
            Sauces = new HashSet<Sauce>();
        }

    }
}
