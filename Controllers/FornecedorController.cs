using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gran_Prix.Models;
using Projeto_Gran_Prix.Data;

namespace Projeto_Gran_Prix.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FornecedorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Fornecedor
        public async Task<IActionResult> Index()
        {
              return _context.Fornecedor != null ? 
                          View(await _context.Fornecedor.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.FornecedorModel'  is null.");
        }

        // GET: Fornecedor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Fornecedor == null)
            {
                return NotFound();
            }

            var fornecedorModel = await _context.Fornecedor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fornecedorModel == null)
            {
                return NotFound();
            }

            return View(fornecedorModel);
        }

        // GET: Fornecedor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fornecedor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome")] FornecedorModel fornecedorModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fornecedorModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedorModel);
        }

        // GET: Fornecedor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Fornecedor == null)
            {
                return NotFound();
            }

            var fornecedorModel = await _context.Fornecedor.FindAsync(id);
            if (fornecedorModel == null)
            {
                return NotFound();
            }
            return View(fornecedorModel);
        }

        // POST: Fornecedor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome")] FornecedorModel fornecedorModel)
        {
            if (id != fornecedorModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fornecedorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorModelExists(fornecedorModel.Id))
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
            return View(fornecedorModel);
        }

        // GET: Fornecedor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Fornecedor == null)
            {
                return NotFound();
            }

            var fornecedorModel = await _context.Fornecedor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fornecedorModel == null)
            {
                return NotFound();
            }

            return View(fornecedorModel);
        }

        // POST: Fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Fornecedor == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FornecedorModel'  is null.");
            }
            var fornecedorModel = await _context.Fornecedor.FindAsync(id);
            if (fornecedorModel != null)
            {
                _context.Fornecedor.Remove(fornecedorModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FornecedorModelExists(int id)
        {
          return (_context.Fornecedor?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
