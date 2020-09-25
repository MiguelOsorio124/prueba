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
    public class StudentsController : ControllerBase
    {
        private readonly DMVDataContext _context;

        public StudentsController(DMVDataContext context)
        {
            _context = context;
            if (_context.Students.Count() == 0)
            {
                _context.Students.Add(new Student { NombreStudent = "Student1", EdadStudent = 20, EstadoStudent = "activo" });
                _context.Students.Add(new Student { NombreStudent = "Student2", EdadStudent = 21, EstadoStudent = "activo" });
                _context.Students.Add(new Student { NombreStudent = "Student3", EdadStudent = 22, EstadoStudent = "activo" });
                _context.SaveChanges();
            }
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _context.Students.Include(q => q.StudentCourses).ToListAsync();
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _context.Students.Include(q => q.StudentCourses).FirstOrDefaultAsync(q => q.IdStudent == id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if(student.NombreStudent.Length < 1)
            {
                return NotFound("El nombre del alumno no puede estar en blanco");
            }
            else if (student.EdadStudent < 18)
            {
                return NotFound("El alumno debe ser mayor de 18 años para poder matricularse");
            }
            else
            {
                if (id != student.IdStudent)
                {
                    return BadRequest();
                }

                _context.Entry(student).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(id))
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

        // POST: api/Students
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            if(student.NombreStudent.Length<1)
            {
                return NotFound("El nombre del alumno no puede estar en blanco");
            }
            else if (student.EdadStudent < 18)
            {
                return NotFound("El alumno debe ser mayor de 18 años para poder matricularse");
            }
            else
            {
                _context.Students.Add(student);
                await _context.SaveChangesAsync();
               
            }
            return NoContent();

        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return student;
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.IdStudent == id);
        }
    }
}
