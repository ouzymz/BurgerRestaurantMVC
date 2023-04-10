using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Extra : BaseEntity
    {
        //nav props
        public ICollection<Order> Orders { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public Extra()
        {
            Orders = new HashSet<Order>();
            Comments = new HashSet<Comment>();
        }
    }
}
