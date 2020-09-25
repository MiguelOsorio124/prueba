using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Ciudad
    {
        [Key]
        public int IdCiudad { get; set; }
        public string NombreCiudad { get; set; }
        public List<Residencial> Residenciales { get; set; }
    }
}
