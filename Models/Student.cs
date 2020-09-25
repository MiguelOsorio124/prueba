using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }
        public string NombreStudent { get; set; }
        public int EdadStudent { get; set; }
        public string EstadoStudent { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }       

    }
}
