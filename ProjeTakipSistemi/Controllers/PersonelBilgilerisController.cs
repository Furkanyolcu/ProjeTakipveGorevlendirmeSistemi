using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjeTakipSistemi.Models.DBContext;
using ProjeTakipSistemi.Models.Personel;
using System.Net;

namespace ProjeTakipSistemi.Controllers
{
    public class PersonelBilgilerisController : Controller
    {
        private readonly Context db = new Context();

        public IActionResult Index()
        {
            return View(db.PersonelBilgileris.ToList());
        }

        public ActionResult PersonelKart()
        {
            return View(db.PersonelBilgileris.ToList());
        }

        public ActionResult Create() //EKLEME OLUŞTURMA
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonelBilgileri personelBilgileri)
        {
              db.PersonelBilgileris.Add(personelBilgileri);
              db.SaveChanges();

            return RedirectToAction("Index", "PersonelBilgileris");
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);

            if (personelBilgileri == null)
            {
                return NotFound();
            }

            return View(personelBilgileri);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            PersonelBilgileri personelBilgileri = db.PersonelBilgileris.Find(id);

            if (personelBilgileri == null)
            {
                return NotFound();
            }

            return View(personelBilgileri);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonelBilgileri personelBilgileri)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personelBilgileri).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personelBilgileri);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var personelBilgileri = db.PersonelBilgileris.Find(id);

            if (personelBilgileri == null)
            {
                return NotFound();
            }

            db.PersonelBilgileris.Remove(personelBilgileri);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
