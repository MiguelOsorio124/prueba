using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.Controllers
{
    public class VehiculoMap : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.ToTable("Vehiculo", "dbo");
            builder.HasKey(q => q.Id);
            builder.Property(e => e.Id).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreVehiculo).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.MarcaVehiculo).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.ColorVehiculo).HasColumnType("varchar(50)").IsRequired();
            builder.Property(e => e.AñoVehiculo).HasColumnType("int").IsRequired();

            builder.HasOne(e => e.Categoria).WithMany(e => e.Vehiculos).HasForeignKey(e => e.IdCategoria);
        }
    }
}
