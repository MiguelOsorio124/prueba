using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCoursesController : ControllerBase
    {
        private readonly DMVDataContext _context;

        public StudentCoursesController(DMVDataContext context)
        {
            _context = context;
        }

        // GET: api/StudentCourses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentCourse>>> GetStudentCourses()
        {
            return await _context.StudentCourses.Include(q => q.Student).Include(e => e.Course).ToListAsync();
        }

        // GET: api/StudentCourses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentCourse>> GetStudentCourse(int id)
        {
            var studentCourse = await _context.StudentCourses.Include(q => q.Student).Include(e => e.Course).FirstOrDefaultAsync(q => q.IdStudentCourse == id);

            if (studentCourse == null)
            {
                return NotFound();
            }

            return studentCourse;
        }
        

        // POST: api/StudentCourses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StudentCourse>> PostStudentCourse(StudentCourse studentCourse)
        {
            
            Student student = await _context.Students.FirstOrDefaultAsync(q => q.IdStudent == studentCourse.IdStudentCourse);
            
                      
            if (StudentExists(studentCourse.IdStudent) == false)
            {
                return NotFound("El estudiante debe de existir");

            }
            else if (CourseExists(studentCourse.IdCourse) == false)
            {
                return NotFound("La clase debe de existir");

            }/*
            else if (student.EstadoStudent != "activo")
            {
                return NotFound("El estudiante debe de estar activo");
            }*/
            if (CountCourses(studentCourse.IdStudent) >4)
            {
                return NotFound("El estudiante ha llegado al maximo de clases");
            }
            else
            {
                _context.StudentCourses.Add(studentCourse);
                await _context.SaveChangesAsync();
            }            

            return NoContent();
        }

        // DELETE: api/StudentCourses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentCourse>> DeleteStudentCourse(int id)
        {
            var studentCourse = await _context.StudentCourses.FindAsync(id);
            if (studentCourse == null)
            {
                return NotFound();
            }

            _context.StudentCourses.Remove(studentCourse);
            await _context.SaveChangesAsync();

            return studentCourse;
        }

        private bool StudentCourseExists(int id)
        {
            return _context.StudentCourses.Any(e => e.IdStudentCourse == id);
        }
        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.IdStudent == id);
        }
        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.IdCourse == id);
        }

        private int CountCourses(int id)
        {            
            return _context.StudentCourses.Count();
        }

        
    }
}
