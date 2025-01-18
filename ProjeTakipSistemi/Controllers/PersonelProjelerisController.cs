using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjeTakipSistemi.Models.DBContext;
using ProjeTakipSistemi.Models.GorevAtama;

namespace ProjeTakipSistemi.Controllers
{
    public class PersonelProjelerisController : Controller
    {
        private readonly Context _context;

        public PersonelProjelerisController(Context context)
        {
            _context = context;
        }

        // GET: PersonelProjeleris
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonelProjeleris.ToListAsync());
        }

        // GET: PersonelProjeleris/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personelProjeleri = await _context.PersonelProjeleris
                .FirstOrDefaultAsync(m => m.PersonelProjeId == id);
            if (personelProjeleri == null)
            {
                return NotFound();
            }

            return View(personelProjeleri);
        }

        // GET: PersonelProjeleris/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonelProjeleris/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonelProjeId,ProjeBaslik,ProjeAciklama,OlusturmaTarihi,OncelikDurumu,TamamlanmaOrani,TamamlanmaTarihi,TamamlanmaDurumu")] PersonelProjeleri personelProjeleri)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personelProjeleri);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personelProjeleri);
        }

        // GET: PersonelProjeleris/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personelProjeleri = await _context.PersonelProjeleris.FindAsync(id);
            if (personelProjeleri == null)
            {
                return NotFound();
            }
            return View(personelProjeleri);
        }

        // POST: PersonelProjeleris/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonelProjeId,ProjeBaslik,ProjeAciklama,OlusturmaTarihi,OncelikDurumu,TamamlanmaOrani,TamamlanmaTarihi,TamamlanmaDurumu")] PersonelProjeleri personelProjeleri)
        {
            if (id != personelProjeleri.PersonelProjeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personelProjeleri);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonelProjeleriExists(personelProjeleri.PersonelProjeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(personelProjeleri);
        }

        // GET: PersonelProjeleris/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personelProjeleri = await _context.PersonelProjeleris
                .FirstOrDefaultAsync(m => m.PersonelProjeId == id);
            if (personelProjeleri == null)
            {
                return NotFound();
            }

            return View(personelProjeleri);
        }

        // POST: PersonelProjeleris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personelProjeleri = await _context.PersonelProjeleris.FindAsync(id);
            if (personelProjeleri != null)
            {
                _context.PersonelProjeleris.Remove(personelProjeleri);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonelProjeleriExists(int id)
        {
            return _context.PersonelProjeleris.Any(e => e.PersonelProjeId == id);
        }
    }
}
