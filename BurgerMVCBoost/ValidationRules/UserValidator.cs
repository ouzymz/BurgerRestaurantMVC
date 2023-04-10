using BurgerMVC.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<RegisterVM>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName)
                .NotEmpty()
                .WithMessage("Kullanıcı adı boş bırakılamaz");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email boş bırakılamaz.");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Şifreniz boş olamaz.");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty()
                .WithMessage("Şifreler aynı değil.");
        }
    }
}
