using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BurgerMVCBoost.ViewModel
{
    public class UserVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Comment { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        public string Email { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Compare("Password")]
        [Display(Name = "Şifreyi Onayla")]
        public string ConfirmPassword { get; set; }

        public string ReturnUrl { get; set; }
    }
}
