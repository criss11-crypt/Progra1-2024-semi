using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_2024.Models;

namespace proyecto_2024.Controllers
{
    [Route("Bomberos")]
    [ApiController]
    public class BomberosController : Controller
    {
        private readonly MvccrudContext _context;

        public BomberosController(MvccrudContext context)
        {
            _context = context;
        }

        // GET: Bomberos
        [HttpGet("")]
        public async Task<IActionResult> Index(string? buscar)
        {
            var bomberos = from bombero in _context.Bomberos select bombero;

            if (!string.IsNullOrEmpty(buscar))
            {
                bomberos = bomberos.Where(s =>
                    s.Nombre!.Contains(buscar) ||
                    s.Direccion!.Contains(buscar) ||
                    s.Dui!.Contains(buscar));
            }

            return View(await bomberos.ToListAsync());
        }

        // GET: Bomberos/Detalles/5
        [HttpGet("Detalles/{id}")]
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bombero = await _context.Bomberos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bombero == null)
            {
                return NotFound();
            }

            return View(bombero);
        }

        // GET: Bomberos/Crear
        [HttpGet("Crear")]
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Bomberos/Crear
        [HttpPost("Crear")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([FromForm][Bind("Id,Nombre,Direccion,Dui,DescripcionCaso")] Bomberos bombero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bombero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bombero);
        }

        // GET: Bomberos/Editar/5
        [HttpGet("Editar/{id}")]
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bombero = await _context.Bomberos.FindAsync(id);
            if (bombero == null)
            {
                return NotFound();
            }
            return View(bombero);
        }

        // POST: Bomberos/Editar/5
        [HttpPost("Editar/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nombre,Direccion,Dui,DescripcionCaso")] Bomberos bombero)
        {
            if (id != bombero.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bombero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BomberoExists(bombero.Id))
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
            return View(bombero);
        }

        // GET: Bomberos/Eliminar/5
        [HttpGet("Eliminar/{id}")]
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bombero = await _context.Bomberos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bombero == null)
            {
                return NotFound();
            }

            return View(bombero);
        }

        // POST: Bomberos/Eliminar/5
        [HttpPost("Eliminar/{id}"), ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarConfirmed(int id)
        {
            var bombero = await _context.Bomberos.FindAsync(id);
            if (bombero != null)
            {
                _context.Bomberos.Remove(bombero);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BomberoExists(int id)
        {
            return _context.Bomberos.Any(e => e.Id == id);
        }
    }
}