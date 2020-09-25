using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Genero
    {
        [Key]
        public int IdGenero { get; set; }
        public string NombreGenero { get; set; }
        public List<Cancion> Canciones { get; set; }
    }
}
