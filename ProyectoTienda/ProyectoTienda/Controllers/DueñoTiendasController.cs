using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoTienda.Data;
using ProyectoTienda.Models;
using ProyectoTienda.ViewModels;

namespace ProyectoTienda.Controllers
{
    [Authorize]
    public class DueñoTiendasController : Controller
    {
        private readonly MainContext _context;

        public DueñoTiendasController(MainContext context)
        {
            _context = context;
        }

        // GET: DueñoTiendas
        public async Task<IActionResult> Index()
        {
           /* if dueñoTienda.FotoBase64 == null {
            * return View predeterminado (imagen descargada)
            * }else{
            * dueñoTienda.ForEach
            * }
            */
            /*var dueñoTienda = await _context.DueñoTienda.ToListAsync();
            dueñoTienda.ForEach(cadaDueño => cadaDueño.FotoBase64 = $"data:image/png;base64,{Convert.ToBase64String(cadaDueño.Foto)}");
            return View(dueñoTienda);*/
            return View(await _context.DueñoTienda.ToListAsync());
        }

        // GET: DueñoTiendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dueñoTienda = await _context.DueñoTienda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dueñoTienda == null)
            {
                return NotFound();
            }

            return View(dueñoTienda);
        }

        // GET: DueñoTiendas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DueñoTiendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind("Id,Foto,Nombre,Detalle,Cantidad,Precio")]*/ DueñoViewModel dueñoViewModel)
        {
            //    if (ModelState.IsValid)
            //    {
            //        _context.Add(dueñoTienda);
            //        await _context.SaveChangesAsync();
            //        return RedirectToAction(nameof(Index));
            //    }
            //    return View(dueñoTienda);
            //}

            if (ModelState.IsValid)
            {
                DueñoTienda dueñoTienda = new DueñoTienda();
                dueñoTienda.Nombre = dueñoViewModel.Nombre;
                dueñoTienda.Detalle = dueñoViewModel.Detalle;
                dueñoTienda.Cantidad = dueñoViewModel.Cantidad;
                dueñoTienda.Precio = dueñoViewModel.Precio;
                dueñoTienda.Foto = ConvertirArregloByte(dueñoViewModel.Foto);
                _context.Add(dueñoTienda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dueñoViewModel);
        }

        private byte[] ConvertirArregloByte(IFormFile formFile)
        {
            if (formFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    formFile.CopyTo(memoryStream);
                    var tamanoMaximo = 2097152; //si el archivo es mas grande usar streaming
                    if (memoryStream.Length < tamanoMaximo)
                        return memoryStream.ToArray();
                }
            }
            return null;
        }
        // GET: DueñoTiendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dueñoTienda = await _context.DueñoTienda.FindAsync(id);
            if (dueñoTienda == null)
            {
                return NotFound();
            }
            return View(dueñoTienda);
        }

        // POST: DueñoTiendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Detalle,Cantidad,Precio")] DueñoTienda dueñoTienda)
        {
            if (id != dueñoTienda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dueñoTienda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DueñoTiendaExists(dueñoTienda.Id))
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
            return View(dueñoTienda);
        }

        // GET: DueñoTiendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dueñoTienda = await _context.DueñoTienda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dueñoTienda == null)
            {
                return NotFound();
            }

            return View(dueñoTienda);
        }

        // POST: DueñoTiendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dueñoTienda = await _context.DueñoTienda.FindAsync(id);
            _context.DueñoTienda.Remove(dueñoTienda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DueñoTiendaExists(int id)
        {
            return _context.DueñoTienda.Any(e => e.Id == id);
        }
    }
}
