using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bazaar.Core;
using bazaar.Persistance;

namespace bazaar.Controllers
{
    public class GoodsRegisterController : Controller
    {
        private readonly BazaarContext _context;

        public GoodsRegisterController(BazaarContext context)
        {
            _context = context;
        }

        // GET: GoodsRegister
        public async Task<IActionResult> Index()
        {
              return _context.Goods != null ? 
                          View(await _context.Goods.ToListAsync()) :
                          Problem("Entity set 'Context.Goods'  is null.");
        }

        // GET: GoodsRegister/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Goods == null)
            {
                return NotFound();
            }

            var goods = await _context.Goods
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goods == null)
            {
                return NotFound();
            }

            return View(goods);
        }

        // GET: GoodsRegister/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GoodsRegister/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Code,Description,Id,CreateTime")] Goods goods)
        {
            if (ModelState.IsValid)
            {
                _context.Add(goods);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(goods);
        }

        // GET: GoodsRegister/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Goods == null)
            {
                return NotFound();
            }

            var goods = await _context.Goods.FindAsync(id);
            if (goods == null)
            {
                return NotFound();
            }
            return View(goods);
        }

        // POST: GoodsRegister/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Title,Code,Description,Id,CreateTime")] Goods goods)
        {
            if (id != goods.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(goods);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GoodsExists(goods.Id))
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
            return View(goods);
        }

        // GET: GoodsRegister/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Goods == null)
            {
                return NotFound();
            }

            var goods = await _context.Goods
                .FirstOrDefaultAsync(m => m.Id == id);
            if (goods == null)
            {
                return NotFound();
            }

            return View(goods);
        }

        // POST: GoodsRegister/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Goods == null)
            {
                return Problem("Entity set 'Context.Goods'  is null.");
            }
            var goods = await _context.Goods.FindAsync(id);
            if (goods != null)
            {
                _context.Goods.Remove(goods);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GoodsExists(long id)
        {
          return (_context.Goods?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
