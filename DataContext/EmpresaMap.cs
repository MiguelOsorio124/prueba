using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa", "dbo");
            builder.HasKey(q => q.IdEmpresa);
            builder.Property(e => e.IdEmpresa).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreEmpresa).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.MaxEmpleadosEmpresa).HasColumnType("int").IsRequired();
        }
    }
}
