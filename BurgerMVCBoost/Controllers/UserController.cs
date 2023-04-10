using AutoMapper;
using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVC.ViewModel;
using BurgerMVCBoost.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Security.Claims;

namespace BurgerMVCBoost.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IPasswordHasher<AppUser> _passwordHasher;
        private readonly IMapper _mapper;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;

        public UserController(UserManager<AppUser> userManager, IPasswordHasher<AppUser> passwordHasher, IMapper mapper, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
                _mapper.Map(register, appUser);

                IdentityResult result = await _userManager.CreateAsync(appUser, register.Password);
                await _userManager.AddToRoleAsync(appUser, "Customer");

                if (result.Succeeded)
                    return RedirectToAction("Login");
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(register);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            returnUrl = returnUrl is null ? "Home/Index" : returnUrl;
            return View(new LoginVM() { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByNameAsync(user.UserName);

                if (appUser != null)
                {
                    await _signInManager.SignOutAsync();

                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, user.Password, false, false);

                    if (result.Succeeded)
                        return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Yanlış Kullanıcı Adı/Şifre.");
                }
            }
            return View(user);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }

        public async Task<IActionResult> ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM forgot)
        {
            Guid guid = Guid.NewGuid();
            forgot.Password = guid.ToString().Substring(0, 8);

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(forgot.Email);
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, forgot.Password);
                await _userManager.UpdateAsync(user);
                forgot.UserName = user.UserName;
                SendMail(forgot);
                return RedirectToAction("Login");
            }
            else
                ModelState.AddModelError("", "Geçersiz e-mail adresi.");
            return View();
        }

        private void SendMail(ForgotPasswordVM forgot)
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("ucsilahsorlerburger@gmail.com");
            mesaj.To.Add($"{forgot.Email}");
            mesaj.Subject = "Şifre Sıfırlama";
            mesaj.Body = $"Şifreniz Sıfırlandı.\nKullanıcı Adınız={forgot.UserName}\nYeni Şifreniz={forgot.Password}";

            SmtpClient a = new SmtpClient();
            a.Credentials = new System.Net.NetworkCredential("ucsilahsorlerburger@gmail.com", "xdgpgeouvssyfpzk");
            a.Port = 587;
            a.Host = "smtp.gmail.com";
            a.EnableSsl = true;
            object userState = mesaj;
            //a.Send(mesaj);
            a.SendAsync(mesaj, userState);
        }

        public IActionResult FacebookLogin(string ReturnUrl)
        {
            string redirectUrl = Url.Action("FacebookResponse", "User", new { ReturnUrl = ReturnUrl });
            AuthenticationProperties properties = _signInManager.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            return new ChallengeResult("Facebook", properties);
        }

        public async Task<IActionResult> FacebookResponse(string ReturnUrl = "/")
        {
            ExternalLoginInfo loginInfo = await _signInManager.GetExternalLoginInfoAsync();

            if (loginInfo == null)
                return RedirectToAction("Login");
            else
            {
                Microsoft.AspNetCore.Identity.SignInResult loginResult = await _signInManager.ExternalLoginSignInAsync(loginInfo.LoginProvider, loginInfo.ProviderKey, true);

                if (loginResult.Succeeded)
                    return Redirect(ReturnUrl);
                else
                {
                    AppUser user = new AppUser
                    {
                        Email = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value,
                        UserName = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value
                    };

                    IdentityResult createResult = await _userManager.CreateAsync(user);
                    await _userManager.AddToRoleAsync(user, "Customer");

                    if (createResult.Succeeded)
                    {
                        IdentityResult addLoginResult = await _userManager.AddLoginAsync(user, loginInfo);

                        if (addLoginResult.Succeeded)
                        {
                            await _signInManager.SignInAsync(user, true);
                            return Redirect(ReturnUrl);
                        }
                    }
                }
            }
            return Redirect(ReturnUrl);
        }

        public IActionResult GoogleLogin(string ReturnUrl)
        {
            string redirectUrl = Url.Action("GoogleResponse", "User", new { ReturnUrl = ReturnUrl });
            AuthenticationProperties properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);

            return new ChallengeResult("Google", properties);
        }

        public async Task<IActionResult> GoogleResponse(string ReturnUrl = "/")
        {
            ExternalLoginInfo loginInfo = await _signInManager.GetExternalLoginInfoAsync();

            if (loginInfo == null)
                return RedirectToAction("Login");
            else
            {
                Microsoft.AspNetCore.Identity.SignInResult loginResult = await _signInManager.ExternalLoginSignInAsync(loginInfo.LoginProvider, loginInfo.ProviderKey, true);

                if (loginResult.Succeeded)
                    return Redirect(ReturnUrl);
                else
                {
                    AppUser user = new AppUser
                    {
                        Email = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value,
                        UserName = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value
                    };
                    IdentityResult createResult = await _userManager.CreateAsync(user);
                    await _userManager.AddToRoleAsync(user, "Customer");

                    if (createResult.Succeeded)
                    {
                        IdentityResult addLoginResult = await _userManager.AddLoginAsync(user, loginInfo);

                        if (addLoginResult.Succeeded)
                        {
                            await _signInManager.SignInAsync(user, true);
                            return Redirect(ReturnUrl);
                        }
                    }
                }
            }
            return Redirect(ReturnUrl);
        }
    }
}