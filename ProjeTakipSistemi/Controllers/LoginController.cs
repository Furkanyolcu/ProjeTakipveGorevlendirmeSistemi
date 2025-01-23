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
        [HttpPost]
        public async Task<IActionResult> Index(string email, string password)
        {
            // Kullanıcı giriş bilgilerini kontrol et
            var user = await db.Users.FirstOrDefaultAsync(x => x.UserEmail == email && x.UserPassword == password);

            if (user != null)
            {
                // Kullanıcı adını oturuma kaydet
                HttpContext.Session.SetString("UserNameSurname", user.UserNameSurname);

                // Giriş başarılı, kullanıcıyı "Panel" sayfasına yönlendir
                return RedirectToAction("Index", "PersonelBilgileris");
            }

            // Giriş başarısızsa hata mesajı ekle
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
            Console.WriteLine($"Email: {email}, Password: {password}, UserNameSurname: {UserNameSurname}");

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
