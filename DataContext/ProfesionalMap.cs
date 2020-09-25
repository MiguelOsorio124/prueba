using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class ProfesionalMap : IEntityTypeConfiguration<Profesional>
    {
        public void Configure(EntityTypeBuilder<Profesional> builder)
        {
            builder.ToTable("Profesional", "dbo");
            builder.HasKey(q => q.IdProfesional);
            builder.Property(e => e.IdProfesional).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreProfesional).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.EdadProfesional).HasColumnType("int").IsRequired();
            builder.Property(e => e.EstadoProfesional).HasColumnType("bit").IsRequired();


            builder.HasOne(e => e.Empresa).WithMany(e => e.Profesionales).HasForeignKey(e => e.IdEmpresa);
        }
    }
}
