using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyecto_2024.Models;

namespace proyecto_2024.Controllers
{
    [Route("Hospital")]
    [ApiController]
    public class HospitalsController : Controller
    {
        private readonly MvccrudContext _context;

        public HospitalsController(MvccrudContext context)
        {
            _context = context;
        }

        // GET: Hospital
        [HttpGet("")]
        public async Task<IActionResult> Index(string? buscar)
        {
            var hospitals = from hospital in _context.Hospitals select hospital;

            if (!string.IsNullOrEmpty(buscar))
            {
                hospitals = hospitals.Where(s =>
                    s.Nombre!.Contains(buscar) ||
                    s.Direccion!.Contains(buscar) ||
                    s.Dui!.Contains(buscar));
            }

            return View(await hospitals.ToListAsync());
        }

        // GET: Hospital/Detalles/5
        [HttpGet("Detalles/{id}")]
        public async Task<IActionResult> Detalles(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital = await _context.Hospitals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hospital == null)
            {
                return NotFound();
            }

            return View(hospital);
        }

        // GET: Hospital/Crear
        [HttpGet("Crear")]
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Hospital/Crear
        [HttpPost("Crear")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([FromForm][Bind("Id,Nombre,Direccion,Dui,DescripcionCaso")] Hospital hospital)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hospital);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hospital);
        }

        // GET: Hospital/Editar/5
        [HttpGet("Editar/{id}")]
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital = await _context.Hospitals.FindAsync(id);
            if (hospital == null)
            {
                return NotFound();
            }
            return View(hospital);
        }

        // POST: Hospital/Editar/5
        [HttpPost("Editar/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("Id,Nombre,Direccion,Dui,DescripcionCaso")] Hospital hospital)
        {
            if (id != hospital.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hospital);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HospitalExists(hospital.Id))
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
            return View(hospital);
        }

        // GET: Hospital/Eliminar/5
        [HttpGet("Eliminar/{id}")]
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hospital = await _context.Hospitals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hospital == null)
            {
                return NotFound();
            }

            return View(hospital);
        }

        // POST: Hospital/Eliminar/5
        [HttpPost("Eliminar/{id}"), ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EliminarConfirmed(int id)
        {
            var hospital = await _context.Hospitals.FindAsync(id);
            if (hospital != null)
            {
                _context.Hospitals.Remove(hospital);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HospitalExists(int id)
        {
            return _context.Hospitals.Any(e => e.Id == id);
        }
    }
}