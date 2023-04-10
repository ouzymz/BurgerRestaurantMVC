using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Sauce : BaseEntity
    {
        //Nav Props
        public ICollection<Order> Orders { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public Sauce()
        {
            Orders = new HashSet<Order>();
            Comments = new HashSet<Comment>();
        }
    }
}
