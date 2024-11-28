using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proyecto_2024.Models;

namespace proyecto_2024.Controllers
{
    [Route("Policia")]
    [ApiController]
    public class PoliciasController : Controller
    {
        private readonly MvccrudContext _context;

        public PoliciasController(MvccrudContext context)
        {
            _context = context;
        }

        // GET: Policia
        [HttpGet("")]
        public async Task<IActionResult> Index(string? buscar)
        {
            var policias = from policia in _context.Policias select policia;

            if (!string.IsNullOrEmpty(buscar))
            {
                policias = policias.Where(s =>
                    s.Nombre!.Contains(buscar) ||
                    s.Direccion!.Contains(buscar) ||
                    s.Dui!.Contains(buscar));
            }

            return View(await policias.ToListAsync());
        }

        // GET: Policia/Detalles/5
        [HttpGet("Detalles/{id}")]
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policia = await _context.Policias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (policia == null)
            {
                return NotFound();
            }

            return View(policia);
        }

        // GET: Policia/Crear
        [HttpGet("Crear")]
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Policia/Crear
        [HttpPost("Crear")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([FromForm][Bind("Id,Nombre,Direccion,Dui,DescripcionCaso")] Policia policia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(policia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(policia);
        }

        // GET: Policia/Editar/5
        [HttpGet("Editar/{id}")]
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policia = await _context.Policias.FindAsync(id);
            if (policia == null)
            {
                return NotFound();
            }
            return View(policia);
        }

        // POST: Policia/Editar/5
        [HttpPost("Editar/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nombre,Direccion,Dui,DescripcionCaso")] Policia policia)
        {
            if (id != policia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Forzar la actualización
                    _context.Entry(policia).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PoliciaExists(policia.Id))
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
            return View(policia);
        }

        // GET: Policia/Eliminar/5
        [HttpGet("Eliminar/{id}")]
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policia = await _context.Policias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (policia == null)
            {
                return NotFound();
            }

            return View(policia);
        }

        // POST: Policia/Eliminar/5
        [HttpPost("Eliminar/{id}"), ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarConfirmed(int id)
        {
            var policia = await _context.Policias.FindAsync(id);
            if (policia != null)
            {
                _context.Policias.Remove(policia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PoliciaExists(int id)
        {
            return _context.Policias.Any(e => e.Id == id);
        }
    }
}