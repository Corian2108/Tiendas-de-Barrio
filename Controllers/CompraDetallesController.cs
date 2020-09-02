using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoTienda.Data;
using ProyectoTienda.Models;

namespace ProyectoTienda.Controllers
{
    public class CompraDetallesController : Controller
    {
        private readonly MainContext _context;

        public CompraDetallesController(MainContext context)
        {
            _context = context;
        }

        // GET: CompraDetalles
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompraDetalle.ToListAsync());
        }

        // GET: CompraDetalles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compraDetalle = await _context.CompraDetalle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compraDetalle == null)
            {
                return NotFound();
            }

            return View(compraDetalle);
        }

        // GET: CompraDetalles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompraDetalles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DetalleCompra,Precio")] CompraDetalle compraDetalle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compraDetalle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(compraDetalle);
        }

        // GET: CompraDetalles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compraDetalle = await _context.CompraDetalle.FindAsync(id);
            if (compraDetalle == null)
            {
                return NotFound();
            }
            return View(compraDetalle);
        }

        // POST: CompraDetalles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DetalleCompra,Precio")] CompraDetalle compraDetalle)
        {
            if (id != compraDetalle.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compraDetalle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompraDetalleExists(compraDetalle.Id))
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
            return View(compraDetalle);
        }

        // GET: CompraDetalles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compraDetalle = await _context.CompraDetalle
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compraDetalle == null)
            {
                return NotFound();
            }

            return View(compraDetalle);
        }

        // POST: CompraDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compraDetalle = await _context.CompraDetalle.FindAsync(id);
            _context.CompraDetalle.Remove(compraDetalle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompraDetalleExists(int id)
        {
            return _context.CompraDetalle.Any(e => e.Id == id);
        }
    }
}
