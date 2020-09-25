using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Vehiculo
    {        
        public int Id { get; set; }
        public string NombreVehiculo { get; set; }
        public string MarcaVehiculo { get; set; }
        public int AñoVehiculo { get; set; }
        public string ColorVehiculo { get; set; }
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }

    }
}
