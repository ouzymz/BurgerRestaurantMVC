using BurgerMVC.EntityLayer.Concrete;

namespace BurgerMVCBoost.ViewModel
{
    public class AllMenuVM
    {
        public AllMenuVM()
        {
            Extras = new List<Extra>();
            Sauces = new List<Sauce>();
            Desserts = new List<Dessert>();
            Menus = new List<Menu>();
            Drinks= new List<Drink>();
        }

        public List<Extra> Extras { get; set; }
        public Extra Extra { get; set; }

        public List<Sauce> Sauces { get; set; }
        public Sauce sauce { get; set; }

        public List<Dessert> Desserts { get; set; }
        public Dessert Dessert { get; set; }

        public List<Menu> Menus { get; set; }
        public Menu Menu { get; set; }

        public List<Drink> Drinks { get; set; }
        public Drink Drink { get; set; }
    }
}
