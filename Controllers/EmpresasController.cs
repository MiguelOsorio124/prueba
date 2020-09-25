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
    public class EmpresasController : ControllerBase
    {
        private readonly DMVDataContext _context;

        public EmpresasController(DMVDataContext context)
        {
            _context = context;
            if (_context.Empresas.Count() == 0)
            {
                _context.Empresas.Add(new Empresa { NombreEmpresa = "Empresa1", MaxEmpleadosEmpresa = 1 });
                _context.Empresas.Add(new Empresa { NombreEmpresa = "Empresa2", MaxEmpleadosEmpresa = 2 });
                _context.Empresas.Add(new Empresa { NombreEmpresa = "Empresa3", MaxEmpleadosEmpresa = 3 });
                _context.SaveChanges();
            }
        }

        // GET: api/Empresas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empresa>>> GetEmpresas()
        {
            return await _context.Empresas.Include(q => q.Profesionales).ToListAsync();
        }

        // GET: api/Empresas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empresa>> GetEmpresa(int id)
        {
            var empresa = await _context.Empresas.Include(q => q.Profesionales).FirstOrDefaultAsync(q => q.IdEmpresa == id);
            if (empresa == null)
            {
                return NotFound();
            }

            return empresa;
        }

        // PUT: api/Empresas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpresa(int id, Empresa empresa)
        {
            if (empresa.NombreEmpresa.Length < 1)
            {
                return NotFound("El nombre del empresa no puede estar en blanco");
            }            
            else
            {
                if (id != empresa.IdEmpresa)
                {
                    return BadRequest();
                }

                _context.Entry(empresa).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpresaExists(id))
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

        // POST: api/Empresas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Empresa>> PostEmpresa(Empresa empresa)
        {
            if (empresa.NombreEmpresa.Length < 1)
            {
                return NotFound("El nombre de la empresa no puede estar en blanco");
            }
            else
            {
                _context.Empresas.Add(empresa);
                await _context.SaveChangesAsync();
            }

            return NoContent();
        }

        // DELETE: api/Empresas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Empresa>> DeleteEmpresa(int id)
        {
            var empresa = await _context.Empresas.FindAsync(id);
            if (empresa == null)
            {
                return NotFound();
            }

            _context.Empresas.Remove(empresa);
            await _context.SaveChangesAsync();

            return empresa;
        }

        private bool EmpresaExists(int id)
        {
            return _context.Empresas.Any(e => e.IdEmpresa == id);
        }
    }
}
