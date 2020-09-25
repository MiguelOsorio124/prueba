using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class Profesional
    {
        [Key]
        public int IdProfesional { get; set; }
        public string NombreProfesional { get; set; }
        public int EdadProfesional { get; set; }
        public bool EstadoProfesional { get; set; }
        public int IdEmpresa { get; set; }
        public Empresa Empresa { get; set; }
    }
}
