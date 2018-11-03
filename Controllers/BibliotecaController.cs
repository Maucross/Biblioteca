using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Context;
using Biblioteca.Models;

namespace jojo.Controllers
{
    public class BibliotecaController : Controller
    {
        private readonly BibliotecaContext _context;

        public BibliotecaController(BibliotecaContext context)
        {
            _context = context;
        }

        // GET: Biblioteca
        public async Task<IActionResult> Index()
        {
            var bibliotecaContext = _context.prestamo.Include(p => p.datosLibro);
            return View(await bibliotecaContext.ToListAsync());
        }

        // GET: Biblioteca/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.prestamo
                .Include(p => p.datosLibro)
                .SingleOrDefaultAsync(m => m.cod_prest == id);
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // GET: Biblioteca/Create
        public IActionResult Create()
        {
            ViewData["cod_lib"] = new SelectList(_context.libros, "cod_lib", "ISBN");
            return View();
        }

        // POST: Biblioteca/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cod_prest,cod_lib,modalidad,fecha_reserva")] prestamo prestamo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(prestamo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["cod_lib"] = new SelectList(_context.libros, "cod_lib", "ISBN", prestamo.cod_lib);
            return View(prestamo);
        }

        // GET: Biblioteca/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.prestamo.SingleOrDefaultAsync(m => m.cod_prest == id);
            if (prestamo == null)
            {
                return NotFound();
            }
            ViewData["cod_lib"] = new SelectList(_context.libros, "cod_lib", "ISBN", prestamo.cod_lib);
            return View(prestamo);
        }

        // POST: Biblioteca/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("cod_prest,cod_lib,modalidad,fecha_reserva")] prestamo prestamo)
        {
            if (id != prestamo.cod_prest)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(prestamo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!prestamoExists(prestamo.cod_prest))
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
            ViewData["cod_lib"] = new SelectList(_context.libros, "cod_lib", "ISBN", prestamo.cod_lib);
            return View(prestamo);
        }

        // GET: Biblioteca/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.prestamo
                .Include(p => p.datosLibro)
                .SingleOrDefaultAsync(m => m.cod_prest == id);
            if (prestamo == null)
            {
                return NotFound();
            }

            return View(prestamo);
        }

        // POST: Biblioteca/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var prestamo = await _context.prestamo.SingleOrDefaultAsync(m => m.cod_prest == id);
            _context.prestamo.Remove(prestamo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool prestamoExists(int id)
        {
            return _context.prestamo.Any(e => e.cod_prest == id);
        }
    }
}
