using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Residencial
    {
        [Key]
        public int IdResidencial { get; set; }
        public string NombreResidencial { get; set; }
        public int IdCiudad { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
