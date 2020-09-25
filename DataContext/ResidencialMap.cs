using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class ResidencialMap : IEntityTypeConfiguration<Residencial>
    {
        public void Configure(EntityTypeBuilder<Residencial> builder)
        {
            builder.ToTable("Residencial", "dbo");
            builder.HasKey(q => q.IdResidencial);
            builder.Property(e => e.IdResidencial).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreResidencial).HasColumnType("varchar(50)").IsRequired();            

            builder.HasOne(e => e.Ciudad).WithMany(e => e.Residenciales).HasForeignKey(e => e.IdCiudad);
        }
    }
}
