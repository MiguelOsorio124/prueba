using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student", "dbo");
            builder.HasKey(q => q.IdStudent);
            builder.Property(e => e.IdStudent).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreStudent).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.EdadStudent).HasColumnType("int").IsRequired();
            builder.Property(e => e.EstadoStudent).HasColumnType("varchar(50)").IsRequired();
        }
    }
}
