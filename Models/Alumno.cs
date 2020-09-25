using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }
        public string NombreAlumno { get; set; }
        public int IdGrado { get; set; }
        public Grado Grado { get; set; }
    }
}
