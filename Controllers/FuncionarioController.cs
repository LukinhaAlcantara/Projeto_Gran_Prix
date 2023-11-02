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
    public class FuncionarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FuncionarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Funcionario
        public async Task<IActionResult> Index()
        {
              return _context.Funcionario != null ? 
                          View(await _context.Funcionario.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.FuncionarioModel'  is null.");
        }

        // GET: Funcionario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Funcionario == null)
            {
                return NotFound();
            }

            var funcionarioModel = await _context.Funcionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionarioModel == null)
            {
                return NotFound();
            }

            return View(funcionarioModel);
        }

        // GET: Funcionario/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Telefone,CPF,Codigo")] FuncionarioModel funcionarioModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(funcionarioModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionarioModel);
        }

        // GET: Funcionario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Funcionario == null)
            {
                return NotFound();
            }

            var funcionarioModel = await _context.Funcionario.FindAsync(id);
            if (funcionarioModel == null)
            {
                return NotFound();
            }
            return View(funcionarioModel);
        }

        // POST: Funcionario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Telefone,CPF,Codigo")] FuncionarioModel funcionarioModel)
        {
            if (id != funcionarioModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcionarioModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionarioModelExists(funcionarioModel.Id))
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
            return View(funcionarioModel);
        }

        // GET: Funcionario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Funcionario == null)
            {
                return NotFound();
            }

            var funcionarioModel = await _context.Funcionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionarioModel == null)
            {
                return NotFound();
            }

            return View(funcionarioModel);
        }

        // POST: Funcionario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Funcionario == null)
            {
                return Problem("Entity set 'ApplicationDbContext.FuncionarioModel'  is null.");
            }
            var funcionarioModel = await _context.Funcionario.FindAsync(id);
            if (funcionarioModel != null)
            {
                _context.Funcionario.Remove(funcionarioModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionarioModelExists(int id)
        {
          return (_context.Funcionario?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
