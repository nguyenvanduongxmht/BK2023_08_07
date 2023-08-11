using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreFirstApplication.Controllers
{
    public class CongTyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CongTyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CongTy
        public async Task<IActionResult> Index()
        {
              return _context.CongTy != null ? 
                          View(await _context.CongTy.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CongTy'  is null.");
        }

        // GET: CongTy/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CongTy == null)
            {
                return NotFound();
            }

            var congTy = await _context.CongTy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (congTy == null)
            {
                return NotFound();
            }

            return View(congTy);
        }

        // GET: CongTy/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CongTy/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,DiaChi,NgayThanhLap")] CongTy congTy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(congTy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(congTy);
        }

        // GET: CongTy/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CongTy == null)
            {
                return NotFound();
            }

            var congTy = await _context.CongTy.FindAsync(id);
            if (congTy == null)
            {
                return NotFound();
            }
            return View(congTy);
        }

        // POST: CongTy/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,DiaChi,NgayThanhLap")] CongTy congTy)
        {
            if (id != congTy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(congTy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CongTyExists(congTy.Id))
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
            return View(congTy);
        }

        // GET: CongTy/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CongTy == null)
            {
                return NotFound();
            }

            var congTy = await _context.CongTy
                .FirstOrDefaultAsync(m => m.Id == id);
            if (congTy == null)
            {
                return NotFound();
            }

            return View(congTy);
        }

        // POST: CongTy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CongTy == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CongTy'  is null.");
            }
            var congTy = await _context.CongTy.FindAsync(id);
            if (congTy != null)
            {
                _context.CongTy.Remove(congTy);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CongTyExists(int id)
        {
          return (_context.CongTy?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
