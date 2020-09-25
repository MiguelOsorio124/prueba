using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class GradoMap : IEntityTypeConfiguration<Grado>
    {
        public void Configure(EntityTypeBuilder<Grado> builder)
        {
            builder.ToTable("Grado", "dbo");
            builder.HasKey(q => q.IdGrado);
            builder.Property(e => e.IdGrado).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreGrado).HasColumnType("varchar(50)").IsRequired();
        }
    }
}
