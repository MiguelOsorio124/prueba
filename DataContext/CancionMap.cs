using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class CancionMap : IEntityTypeConfiguration<Cancion>
    {
        public void Configure(EntityTypeBuilder<Cancion> builder)
        {
            builder.ToTable("Cancion", "dbo");
            builder.HasKey(q => q.IdCancion);
            builder.Property(e => e.IdCancion).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreCancion).HasColumnType("varchar(50)").IsRequired();

            builder.HasOne(e => e.Genero).WithMany(e => e.Canciones).HasForeignKey(e => e.IdGenero);
        }
    }
}
