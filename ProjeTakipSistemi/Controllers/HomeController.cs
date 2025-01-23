using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjeTakipSistemi.Models;
using ProjeTakipSistemi.Models.DBContext;

namespace ProjeTakipSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context db = new Context();
        public ActionResult Index()
        {
            int projeSayisi = db.PersonelProjeleris.Count();
            ViewBag.ProjeSayisi = projeSayisi;

            int tamamlanmisProje = db.PersonelProjeleris.Where(p => p.TamamlanmaDurumu == true).Count();
            ViewBag.TamamlanmisProje = tamamlanmisProje;


            int tamamlanmamisProje = db.PersonelProjeleris.Where(p => p.TamamlanmaDurumu == false).Count();
            ViewBag.TamamlanmamisProje = tamamlanmamisProje;


            var personelProjeListesi = db.PersonelProjeleris.ToList();
            var personelTamamlanmisProjeSayisi = new Dictionary<int, int>(); 
            return View();
        }
    }
}