using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class CiudadMap : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.ToTable("Ciudad", "dbo");
            builder.HasKey(q => q.IdCiudad);
            builder.Property(e => e.IdCiudad).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreCiudad).HasColumnType("varchar(50)").IsRequired();
        }
    }
}
