using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyAspDemos.Data;
using MyAspDemos.Models;

namespace MyAspDemos.Areas.Library.Controllers
{
    [Area("Library")]
    public class NewsPapersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewsPapersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Library/NewsPapers
        public async Task<IActionResult> Index()
        {
            return View(await _context.NewsPapers.ToListAsync());
        }

        // GET: Library/NewsPapers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsPaper = await _context.NewsPapers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newsPaper == null)
            {
                return NotFound();
            }

            return View(newsPaper);
        }

        // GET: Library/NewsPapers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Library/NewsPapers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] NewsPaper newsPaper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(newsPaper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(newsPaper);
        }

        // GET: Library/NewsPapers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsPaper = await _context.NewsPapers.FindAsync(id);
            if (newsPaper == null)
            {
                return NotFound();
            }
            return View(newsPaper);
        }

        // POST: Library/NewsPapers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] NewsPaper newsPaper)
        {
            if (id != newsPaper.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(newsPaper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsPaperExists(newsPaper.Id))
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
            return View(newsPaper);
        }

        // GET: Library/NewsPapers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var newsPaper = await _context.NewsPapers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (newsPaper == null)
            {
                return NotFound();
            }

            return View(newsPaper);
        }

        // POST: Library/NewsPapers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var newsPaper = await _context.NewsPapers.FindAsync(id);
            _context.NewsPapers.Remove(newsPaper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsPaperExists(int id)
        {
            return _context.NewsPapers.Any(e => e.Id == id);
        }
    }
}
