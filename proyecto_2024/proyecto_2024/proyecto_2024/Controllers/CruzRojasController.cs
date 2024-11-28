using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_2024.Models;

namespace proyecto_2024.Controllers
{
    [Route("CruzRoja")]
    [ApiController]
    public class CruzRojasController : Controller
    {
        private readonly MvccrudContext _context;

        public CruzRojasController(MvccrudContext context)
        {
            _context = context;
        }

        // GET: CruzRoja
        [HttpGet("")]
        public async Task<IActionResult> Index(string? buscar)
        {
            var cruzRojas = from cruzRoja in _context.CruzRoja select cruzRoja;

            if (!string.IsNullOrEmpty(buscar))
            {
                cruzRojas = cruzRojas.Where(s =>
                    s.Nombre!.Contains(buscar) ||
                    s.Direccion!.Contains(buscar) ||
                    s.Dui!.Contains(buscar));
            }

            return View(await cruzRojas.ToListAsync());
        }

        // GET: CruzRoja/Detalles/5
        [HttpGet("Detalles/{id}")]
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruzRoja = await _context.CruzRoja
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cruzRoja == null)
            {
                return NotFound();
            }

            return View(cruzRoja);
        }

        // GET: CruzRoja/Crear
        [HttpGet("Crear")]
        public IActionResult Crear()
        {
            return View();
        }

        // POST: CruzRoja/Crear
        [HttpPost("Crear")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([FromForm][Bind("Id,Nombre,Direccion,Dui,DescripcionCaso")] CruzRoja cruzRoja)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cruzRoja);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cruzRoja);
        }

        // GET: CruzRoja/Editar/5
        [HttpGet("Editar/{id}")]
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruzRoja = await _context.CruzRoja.FindAsync(id);
            if (cruzRoja == null)
            {
                return NotFound();
            }
            return View(cruzRoja);
        }

        // POST: CruzRoja/Editar/5
        [HttpPost("Editar/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nombre,Direccion,Dui,DescripcionCaso")] CruzRoja cruzRoja)
        {
            if (id != cruzRoja.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cruzRoja);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CruzRojaExists(cruzRoja.Id))
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
            return View(cruzRoja);
        }

        // GET: CruzRoja/Eliminar/5
        [HttpGet("Eliminar/{id}")]
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cruzRoja = await _context.CruzRoja
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cruzRoja == null)
            {
                return NotFound();
            }

            return View(cruzRoja);
        }

        // POST: CruzRoja/Eliminar/5
        [HttpPost("Eliminar/{id}"), ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarConfirmed(int id)
        {
            var cruzRoja = await _context.CruzRoja.FindAsync(id);
            if (cruzRoja != null)
            {
                _context.CruzRoja.Remove(cruzRoja);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CruzRojaExists(int id)
        {
            return _context.CruzRoja.Any(e => e.Id == id);
        }
    }
}