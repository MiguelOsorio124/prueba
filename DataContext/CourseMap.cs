using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course", "dbo");
            builder.HasKey(q => q.IdCourse);
            builder.Property(e => e.IdCourse).UseIdentityColumn().IsRequired();
            builder.Property(e => e.NombreCourse).HasColumnType("varchar(50)").IsRequired();            
        }
    }
}
