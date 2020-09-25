using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.DataContext
{
    public class StudentCourseMap : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.ToTable("StudentCourse", "dbo");
            builder.HasKey(q => q.IdStudentCourse);
            builder.Property(e => e.IdStudentCourse).UseIdentityColumn().IsRequired();            

            builder.HasOne(e => e.Student).WithMany(e => e.StudentCourses).HasForeignKey(e => e.IdStudent);
            builder.HasOne(e => e.Course).WithMany(e => e.StudentCourses).HasForeignKey(e => e.IdCourse);
        }
    }
}
