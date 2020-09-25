using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Grado
    {
        [Key]
        public int IdGrado { get; set; }
        public string NombreGrado { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }
}
