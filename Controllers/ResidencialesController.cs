using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidencialesController : ControllerBase
    {
        private readonly DMVDataContext _context;

        public ResidencialesController(DMVDataContext context)
        {
            _context = context;
            if (_context.Residenciales.Count() == 0)
            {
                _context.Residenciales.Add(new Residencial { NombreResidencial = "Residencial1", IdCiudad = 1});
                _context.Residenciales.Add(new Residencial { NombreResidencial = "Residencial2", IdCiudad = 2});
                _context.Residenciales.Add(new Residencial { NombreResidencial = "Residencial3", IdCiudad = 3});
                _context.SaveChanges();
            }
        }

        // GET: api/Residenciales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Residencial>>> GetResidenciales()
        {
            return await _context.Residenciales.Include(q => q.Ciudad).ToListAsync();
        }

        // GET: api/Residenciales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Residencial>> GetResidencial(int id)
        {
            var residencial = await _context.Residenciales.Include(q => q.Ciudad).FirstOrDefaultAsync(q => q.IdResidencial == id);

            if (residencial == null)
            {
                return NotFound();
            }

            return residencial;
        }

        // PUT: api/Residenciales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResidencial(int id, Residencial residencial)
        {
            if (id != residencial.IdResidencial)
            {
                return BadRequest();
            }

            _context.Entry(residencial).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResidencialExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Residenciales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Residencial>> PostResidencial(Residencial residencial)
        {
            _context.Residenciales.Add(residencial);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetResidencial", new { id = residencial.IdResidencial }, residencial);
        }

        // DELETE: api/Residenciales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Residencial>> DeleteResidencial(int id)
        {
            var residencial = await _context.Residenciales.FindAsync(id);
            if (residencial == null)
            {
                return NotFound();
            }

            _context.Residenciales.Remove(residencial);
            await _context.SaveChangesAsync();

            return residencial;
        }

        private bool ResidencialExists(int id)
        {
            return _context.Residenciales.Any(e => e.IdResidencial == id);
        }
    }
}
