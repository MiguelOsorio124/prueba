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
    public class CoursesController : ControllerBase
    {
        private readonly DMVDataContext _context;

        public CoursesController(DMVDataContext context)
        {
            _context = context;
            if (_context.Courses.Count() == 0)
            {
                _context.Courses.Add(new Course { NombreCourse = "Course1"});
                _context.Courses.Add(new Course { NombreCourse = "Course2" });
                _context.Courses.Add(new Course { NombreCourse = "Course3" });
                _context.Courses.Add(new Course { NombreCourse = "Course4" });
                _context.Courses.Add(new Course { NombreCourse = "Course5" });
                _context.Courses.Add(new Course { NombreCourse = "Course6" });
                _context.Courses.Add(new Course { NombreCourse = "Course7" });
                _context.Courses.Add(new Course { NombreCourse = "Course8" });
                _context.Courses.Add(new Course { NombreCourse = "Course9" });
                _context.SaveChanges();
            }
        }

        // GET: api/Courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            return await _context.Courses.Include(q => q.StudentCourses).ToListAsync();
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            var course = await _context.Courses.Include(q => q.StudentCourses).FirstOrDefaultAsync(q => q.IdCourse == id);

            if (course == null)
            {
                return NotFound();
            }

            return course;
        }

        // PUT: api/Courses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, Course course)
        {
            if (course.NombreCourse.Length < 1)
            {
                return NotFound("El nombre del curso no puede estar en blanco");
            }
            else
            {
                if (id != course.IdCourse)
                {
                    return BadRequest();
                }

                _context.Entry(course).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(id))
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

        // POST: api/Courses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
            if(course.NombreCourse.Length < 1)
            {
                return NotFound("El nombre del curso no puede estar en blanco");
            }
            else
            {
                _context.Courses.Add(course);
                await _context.SaveChangesAsync();
            }            

            return CreatedAtAction("GetCourse", new { id = course.IdCourse }, course);
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Course>> DeleteCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return course;
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.IdCourse == id);
        }
    }
}
