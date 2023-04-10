using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.ViewModel
{
    public class RegisterVM
    {
        public string Email { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Compare("Password")]
        [Display(Name = "Şifreyi Onayla")]
        public string ConfirmPassword { get; set; }
    }
}
