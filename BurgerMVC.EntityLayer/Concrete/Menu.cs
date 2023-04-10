using BurgerMVC.EntityLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Menu : BaseEntity
    {
        public string Description { get; set; }
        [NotMapped]
        public Size Size { get; set; }

        //Nav Props
        public ICollection<Order> Orders { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public Menu()
        {
            Orders = new HashSet<Order>();
            Comments = new HashSet<Comment>();
        }

    }
}
