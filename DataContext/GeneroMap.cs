using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Genero", "dbo");
            builder.HasKey(q => q.IdGenero);
            builder.Property(e => e.IdGenero).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreGenero).HasColumnType("varchar(50)").IsRequired();
        }
    }
}
