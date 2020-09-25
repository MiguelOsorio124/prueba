using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TareaSemana4._2_MiguelOsorio_21551109.Models
{
    public class StudentCourse
    {
        [Key]
        public int IdStudentCourse { get; set; }
        public int IdStudent { get; set; }
        public int IdCourse {get; set;}
        public Student Student { get; set; }
        public Course Course { get; set; }


    }
}
