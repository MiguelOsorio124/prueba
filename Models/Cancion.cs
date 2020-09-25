using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Cancion
    {
        [Key]
        public int IdCancion { get; set; }
        public string NombreCancion { get; set; }
        public int IdGenero { get; set; }
        public Genero Genero { get; set; }

    }
}
