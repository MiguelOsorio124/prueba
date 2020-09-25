using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class AlumnoMap : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> builder)
        {
            builder.ToTable("Alumno", "dbo");
            builder.HasKey(q => q.IdAlumno);
            builder.Property(e => e.IdAlumno).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreAlumno).HasColumnType("varchar(50)").IsRequired();

            builder.HasOne(e => e.Grado).WithMany(e => e.Alumnos).HasForeignKey(e => e.IdGrado);
        }
    }
}
