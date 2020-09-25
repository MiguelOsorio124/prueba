using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Categoria
    {        
        public int Id { get; set; }
        public string NombreCategoria { get; set; }

        public string DescripcionCategoria { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
    }
}
