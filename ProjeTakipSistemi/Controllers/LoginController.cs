using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjeTakipSistemi.Models;
using ProjeTakipSistemi.Models.DBContext;

namespace ProjeTakipSistemi.Controllers
{
    public class LoginController : Controller
    {
        private readonly Context db = new Context();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] //giriş
        public async Task<IActionResult> Index(string email, string password)
        {
            var user = await db.Users.FirstOrDefaultAsync(x => x.UserEmail == email && x.UserPassword == password);

            if (user != null)
            {
                // Oturuma kaydet
                HttpContext.Session.SetString("UserNameSurname", user.UserNameSurname);

                return RedirectToAction("Index", "PersonelBilgileris");
            }

            ModelState.AddModelError("", "Geçersiz e-posta veya şifre");
            return View();
        }


        [HttpGet]
        public IActionResult Kayıt()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Kayıt(string email, string password, string UserNameSurname)
        {

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(UserNameSurname))
            {
                ModelState.AddModelError("", "Tüm alanları doldurmanız gerekiyor.");
                return View();
            }

            try
            {
                var newUser = new User
                {
                    UserEmail = email,
                    UserPassword = password,
                    UserNameSurname = UserNameSurname
                };

                db.Users.Add(newUser);
                await db.SaveChangesAsync();

                Console.WriteLine("Kayıt başarıyla eklendi.");
                return RedirectToAction("Index", "Login");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                ModelState.AddModelError("", "Kayıt işlemi sırasında bir hata oluştu.");
                return View();
            }
        }

        public IActionResult NotFound()
        {
            return View();
        }
        
    }
}
