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
    public class ProfesionalesController : ControllerBase
    {
        private readonly DMVDataContext _context;

        public ProfesionalesController(DMVDataContext context)
        {
            _context = context;
            if (_context.Profesionales.Count() == 0)
            {
                _context.Profesionales.Add(new Profesional { NombreProfesional = "Profesional1", EdadProfesional = 1, EstadoProfesional = true });
                _context.Profesionales.Add(new Profesional { NombreProfesional = "Profesional2", EdadProfesional = 1, EstadoProfesional = true });
                _context.Profesionales.Add(new Profesional { NombreProfesional = "Profesional3", EdadProfesional = 1, EstadoProfesional = true });
                _context.SaveChanges();
            }
        }

        // GET: api/Profesionales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesional>>> GetProfesionales()
        {
            return await _context.Profesionales.Include(q => q.Empresa).ToListAsync();
        }

        // GET: api/Profesionales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profesional>> GetProfesional(int id)
        {
            var profesional = await _context.Profesionales.Include(q => q.IdEmpresa).FirstOrDefaultAsync(q => q.IdProfesional == id);

            if (profesional == null)
            {
                return NotFound();
            }

            return profesional;
        }

        // PUT: api/Profesionales/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesional(int id, Profesional profesional)
        {
            if (EmpresaExists(profesional.IdEmpresa) == false)
            {
                return NotFound("La empresa debe de existir");

            }
            else
            {
                if (id != profesional.IdProfesional)
                {
                    return BadRequest();
                }

                _context.Entry(profesional).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfesionalExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            

            return NoContent();
        }

        // POST: api/Profesionales
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Profesional>> PostProfesional(Profesional profesional)
        {
            Empresa empresa = await _context.Empresas.FirstOrDefaultAsync(q => q.IdEmpresa == profesional.IdEmpresa);
             if (EmpresaExists(profesional.IdEmpresa) == false)
            {
                return NotFound("La empresa debe de existir");

            }
            else if (profesional.EstadoProfesional != true)
            {
                return NotFound("El profesional debe de estar activo");
            }
            else if (profesional.EdadProfesional < 18)
            {
                return NotFound("El profesional debe ser mayor a 18 años");
            }
                if (CountProfesionales(profesional.IdProfesional) >= empresa.IdEmpresa)
            {
                return NotFound("La empresa ha llegado al limite de empleados");
            }
            else
            {
                _context.Profesionales.Add(profesional);
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }

        // DELETE: api/Profesionales/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Profesional>> DeleteProfesional(int id)
        {
            var profesional = await _context.Profesionales.FindAsync(id);
            if (profesional == null)
            {
                return NotFound();
            }

            _context.Profesionales.Remove(profesional);
            await _context.SaveChangesAsync();

            return profesional;
        }

        private bool ProfesionalExists(int id)
        {
            return _context.Profesionales.Any(e => e.IdProfesional == id); ;
        }
       
        private bool EmpresaExists(int id)
        {
            return _context.Empresas.Any(e => e.IdEmpresa == id);
        }

        private int CountProfesionales(int id)
        {
            return _context.Profesionales.Count();
        }
    }


}
