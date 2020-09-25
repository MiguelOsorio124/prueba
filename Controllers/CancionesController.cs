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
    public class CancionesController : ControllerBase
    {
        private readonly DMVDataContext _context;

        public CancionesController(DMVDataContext context)
        {
            _context = context;
            if (_context.Canciones.Count() == 0)
            {
                _context.Canciones.Add(new Cancion { NombreCancion = "Residencial1", IdGenero = 1 });
                _context.Canciones.Add(new Cancion { NombreCancion = "Residencial2", IdGenero = 2 });
                _context.Canciones.Add(new Cancion { NombreCancion = "Residencial3", IdGenero = 3 });
                _context.SaveChanges();
            }
        }

        // GET: api/Canciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cancion>>> GetCanciones()
        {
            return await _context.Canciones.Include(q => q.Genero).ToListAsync();
        }

        // GET: api/Canciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cancion>> GetCancion(int id)
        {
            var cancion = await _context.Canciones.Include(q => q.Genero).FirstOrDefaultAsync(q => q.IdCancion == id);

            if (cancion == null)
            {
                return NotFound();
            }

            return cancion;
        }

        // PUT: api/Canciones/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCancion(int id, Cancion cancion)
        {
            if (id != cancion.IdCancion)
            {
                return BadRequest();
            }

            _context.Entry(cancion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CancionExists(id))
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

        // POST: api/Canciones
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Cancion>> PostCancion(Cancion cancion)
        {
            _context.Canciones.Add(cancion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCancion", new { id = cancion.IdCancion }, cancion);
        }

        // DELETE: api/Canciones/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cancion>> DeleteCancion(int id)
        {
            var cancion = await _context.Canciones.FindAsync(id);
            if (cancion == null)
            {
                return NotFound();
            }

            _context.Canciones.Remove(cancion);
            await _context.SaveChangesAsync();

            return cancion;
        }

        private bool CancionExists(int id)
        {
            return _context.Canciones.Any(e => e.IdCancion == id);
        }
    }
}
