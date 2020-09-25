using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public int MaxEmpleadosEmpresa { get; set; }
        public List<Profesional> Profesionales { get; set; }
    }
}
