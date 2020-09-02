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
    public class InformacionesController : Controller
    {
        private readonly MainContext _context;

        public InformacionesController(MainContext context)
        {
            _context = context;
        }

        // GET: Informaciones
        public async Task<IActionResult> Index()
        {
            return View(await _context.Informacion.ToListAsync());
        }

        // GET: Informaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var informacion = await _context.Informacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (informacion == null)
            {
                return NotFound();
            }

            return View(informacion);
        }

        // GET: Informaciones/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Informaciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NombreTienda,Ruc,Permisos,Foto,EncardadoEm,PcrEm,EncardadoDes,PcrDes,CorreoElectornico,NumeroCelular,Contraseña,EntregaDomicilio,ReservaPedido,transBancaria,Tarjeta,Otros,Efectivo,FacturaElectronica,FacturaFisica")] Informacion informacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(informacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(informacion);
        }

        // GET: Informaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var informacion = await _context.Informacion.FindAsync(id);
            if (informacion == null)
            {
                return NotFound();
            }
            return View(informacion);
        }

        // POST: Informaciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NombreTienda,Ruc,Permisos,Foto,EncardadoEm,PcrEm,EncardadoDes,PcrDes,CorreoElectornico,NumeroCelular,Contraseña,EntregaDomicilio,ReservaPedido,transBancaria,Tarjeta,Otros,Efectivo,FacturaElectronica,FacturaFisica")] Informacion informacion)
        {
            if (id != informacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(informacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InformacionExists(informacion.Id))
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
            return View(informacion);
        }

        // GET: Informaciones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var informacion = await _context.Informacion
                .FirstOrDefaultAsync(m => m.Id == id);
            if (informacion == null)
            {
                return NotFound();
            }

            return View(informacion);
        }

        // POST: Informaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var informacion = await _context.Informacion.FindAsync(id);
            _context.Informacion.Remove(informacion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InformacionExists(int id)
        {
            return _context.Informacion.Any(e => e.Id == id);
        }
    }
}
