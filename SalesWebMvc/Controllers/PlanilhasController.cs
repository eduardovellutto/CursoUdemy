using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class PlanilhasController : Controller
    {
        private readonly SalesWebMvcContext _context;

        public PlanilhasController(SalesWebMvcContext context)
        {
            _context = context;
        }

        // GET: Planilhas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Planilha.ToListAsync());
        }

        // GET: Planilhas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planilha = await _context.Planilha
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planilha == null)
            {
                return NotFound();
            }

            return View(planilha);
        }

        // GET: Planilhas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Planilhas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Curso,URL,Id,Name,Sobrenome,Email,DataNasc")] Planilha planilha)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planilha);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planilha);
        }

        // GET: Planilhas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planilha = await _context.Planilha.FindAsync(id);
            if (planilha == null)
            {
                return NotFound();
            }
            return View(planilha);
        }

        // POST: Planilhas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Curso,URL,Id,Name,Sobrenome,Email,DataNasc")] Planilha planilha)
        {
            if (id != planilha.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planilha);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlanilhaExists(planilha.Id))
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
            return View(planilha);
        }

        // GET: Planilhas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planilha = await _context.Planilha
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planilha == null)
            {
                return NotFound();
            }

            return View(planilha);
        }

        // POST: Planilhas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planilha = await _context.Planilha.FindAsync(id);
            _context.Planilha.Remove(planilha);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlanilhaExists(int id)
        {
            return _context.Planilha.Any(e => e.Id == id);
        }
    }
}
