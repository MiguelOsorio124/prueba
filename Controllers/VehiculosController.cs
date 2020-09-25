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
    public class VehiculosController : ControllerBase
    {
        private readonly DMVDataContext _context;

        public VehiculosController(DMVDataContext context)
        {
            _context = context;
            if (_context.Vehiculos.Count() == 0)
            {                
                _context.Vehiculos.Add(new Vehiculo { NombreVehiculo = "Vehiculo1", MarcaVehiculo = "Marca1", AñoVehiculo = 2000, ColorVehiculo = "Color1", IdCategoria = 1});
                _context.Vehiculos.Add(new Vehiculo { NombreVehiculo = "Vehiculo2", MarcaVehiculo = "Marca2", AñoVehiculo = 2001, ColorVehiculo = "Color2", IdCategoria = 2 });
                _context.Vehiculos.Add(new Vehiculo { NombreVehiculo = "Vehiculo3", MarcaVehiculo = "Marca3", AñoVehiculo = 2002, ColorVehiculo = "Color3", IdCategoria = 3 });
                _context.SaveChanges();
            }
        }

        // GET: api/Vehiculos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehiculo>>> GetVehiculos()
        {
            return await _context.Vehiculos.Include(q => q.Categoria).ToListAsync();
        }

        // GET: api/Vehiculos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehiculo>> GetVehiculo(int id)
        {
            var vehiculo = await _context.Vehiculos.Include(q => q.Categoria).FirstOrDefaultAsync(q => q.Id == id);

            if (vehiculo == null)
            {
                return NotFound();
            }

            return vehiculo;
        }

        // PUT: api/Vehiculos/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehiculo(int id, Vehiculo vehiculo)
        {
            if (id != vehiculo.Id)
            {
                return BadRequest();
            }

            _context.Entry(vehiculo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VehiculoExists(id))
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

        // POST: api/Vehiculos
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Vehiculo>> PostVehiculo(Vehiculo vehiculo)
        {
            _context.Vehiculos.Add(vehiculo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVehiculo", new { id = vehiculo.Id }, vehiculo);
        }

        // DELETE: api/Vehiculos/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vehiculo>> DeleteVehiculo(int id)
        {
            var vehiculo = await _context.Vehiculos.FindAsync(id);
            if (vehiculo == null)
            {
                return NotFound();
            }

            _context.Vehiculos.Remove(vehiculo);
            await _context.SaveChangesAsync();

            return vehiculo;
        }

        private bool VehiculoExists(int id)
        {
            return _context.Vehiculos.Any(e => e.Id == id);
        }
    }
}
