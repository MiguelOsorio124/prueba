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
    public class CiudadesController : ControllerBase
    {
        private readonly DMVDataContext _context;

        public CiudadesController(DMVDataContext context)
        {
            _context = context;
            if (_context.Ciudades.Count() == 0)
            {
                _context.Ciudades.Add(new Ciudad { NombreCiudad = "Ciudad1"});
                _context.Ciudades.Add(new Ciudad { NombreCiudad = "Ciudad2" });
                _context.Ciudades.Add(new Ciudad { NombreCiudad = "Ciudad3" });
                _context.SaveChanges();
            }
        }

        // GET: api/Ciudades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ciudad>>> GetCiudades()
        {
            return await _context.Ciudades.Include(q => q.Residenciales).ToListAsync();
        }

        // GET: api/Ciudades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ciudad>> GetCiudad(int id)
        {
            var ciudad = await _context.Ciudades.Include(q => q.Residenciales).FirstOrDefaultAsync(q => q.IdCiudad == id);

            if (ciudad == null)
            {
                return NotFound();
            }

            return ciudad;
        }

        // PUT: api/Ciudades/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCiudad(int id, Ciudad ciudad)
        {
            if (id != ciudad.IdCiudad)
            {
                return BadRequest();
            }

            _context.Entry(ciudad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CiudadExists(id))
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

        // POST: api/Ciudades
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Ciudad>> PostCiudad(Ciudad ciudad)
        {
            _context.Ciudades.Add(ciudad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCiudad", new { id = ciudad.IdCiudad }, ciudad);
        }

        // DELETE: api/Ciudades/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ciudad>> DeleteCiudad(int id)
        {
            var ciudad = await _context.Ciudades.FindAsync(id);
            if (ciudad == null)
            {
                return NotFound();
            }

            _context.Ciudades.Remove(ciudad);
            await _context.SaveChangesAsync();

            return ciudad;
        }

        private bool CiudadExists(int id)
        {
            return _context.Ciudades.Any(e => e.IdCiudad == id);
        }
    }
}
