using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Course
    {
        public int IdCourse { get; set; }
        public string NombreCourse { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }

    }
}
