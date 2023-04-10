using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }

        public Guid AppUserId { get; set; }
        public AppUser User { get; set; }

        public int? MenuId { get; set; }
        public Menu? Menu { get; set; }

        public int? DessertId { get; set; }
        public Dessert? Dessert { get; set; }

        public int? DrinkId { get; set; }
        public Drink? Drink { get; set; }

        public int? ExtraId { get; set; }
        public Extra? Extra { get; set; }

        public int? SauceId { get; set; }
        public Sauce? Sauce { get; set; }



    }
}
