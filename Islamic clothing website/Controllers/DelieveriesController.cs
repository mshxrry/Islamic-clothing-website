using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Islamic_clothing_website.Areas.Identity.Data;
using Islamic_clothing_website.Models;

namespace Islamic_clothing_website.Controllers
{
    [Authorize]
    public class DelieveriesController : Controller
    {
        private readonly IslamicClothingContextDb _context;

        public DelieveriesController(IslamicClothingContextDb context)
        {
            _context = context;
        }

        // GET: Delieveries
        public async Task<IActionResult> Index()
        {
            return _context.Delievery != null ?
                        View(await _context.Delievery.ToListAsync()) :
                        Problem("Entity set 'IslamicClothingContextDb.Delievery'  is null.");
        }

        // GET: Delieveries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Delievery == null)
            {
                return NotFound();
            }

            var delievery = await _context.Delievery
                .FirstOrDefaultAsync(m => m.DelieveryId == id);
            if (delievery == null)
            {
                return NotFound();
            }

            return View(delievery);
        }

        // GET: Delieveries/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Delieveries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DelieveryId,DelieveryDate,DelieveryAddress")] Delievery delievery)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(delievery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(delievery);
        }

        // GET: Delieveries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Delievery == null)
            {
                return NotFound();
            }

            var delievery = await _context.Delievery.FindAsync(id);
            if (delievery == null)
            {
                return NotFound();
            }
            return View(delievery);
        }

        // POST: Delieveries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DelieveryId,DelieveryDate,DelieveryAddress")] Delievery delievery)
        {
            if (id != delievery.DelieveryId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(delievery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DelieveryExists(delievery.DelieveryId))
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
            return View(delievery);
        }

        // GET: Delieveries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Delievery == null)
            {
                return NotFound();
            }

            var delievery = await _context.Delievery
                .FirstOrDefaultAsync(m => m.DelieveryId == id);
            if (delievery == null)
            {
                return NotFound();
            }

            return View(delievery);
        }

        // POST: Delieveries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Delievery == null)
            {
                return Problem("Entity set 'IslamicClothingContextDb.Delievery'  is null.");
            }
            var delievery = await _context.Delievery.FindAsync(id);
            if (delievery != null)
            {
                _context.Delievery.Remove(delievery);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DelieveryExists(int id)
        {
            return (_context.Delievery?.Any(e => e.DelieveryId == id)).GetValueOrDefault();
        }
    }
}
