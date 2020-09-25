using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria", "dbo");
            builder.HasKey(q => q.Id);
            builder.Property(e => e.Id).HasColumnType("int").UseIdentityColumn().IsRequired();            
            builder.Property(e => e.DescripcionCategoria).HasColumnType("varchar(50)").IsRequired();
        }
    }
}
