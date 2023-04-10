using BurgerMVCBoost.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace BurgerMVCBoost.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Book()
        {
            BookingVM bookingVM = new BookingVM();
            return View(bookingVM);
        }

        [HttpPost]
        public IActionResult Book(BookingVM bookingVM)
        {
            SendMail(bookingVM);

            return RedirectToAction("Index", "Home");
        }

        private void SendMail(BookingVM bookingVM)
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("ucsilahsorlerburger@gmail.com");
            mesaj.To.Add($"{bookingVM.Mail}");
            mesaj.To.Add("ucsilahsorlerburger@gmail.com");
            mesaj.Subject = "Yeni Rezervasyon Oluşturuldu";
            mesaj.Body = $"Rezervasyon Bilgileri\nKişi={bookingVM.Name}\nTel No={bookingVM.PhoneNumber}\nMail={bookingVM.Mail}\nKişi Sayısı={bookingVM.PersonCount}\nRezervasyon Tarihi={bookingVM.BookDate}";

            SmtpClient a = new SmtpClient();
            a.Credentials = new System.Net.NetworkCredential("ucsilahsorlerburger@gmail.com", "xdgpgeouvssyfpzk");
            a.Port = 587;
            a.Host = "smtp.gmail.com";
            a.EnableSsl = true;
            object userState = mesaj;
            a.SendAsync(mesaj, userState);
        }
    }
}
