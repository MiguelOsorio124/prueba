using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TareaSemana4._2_MiguelOsorio_21551109.DataContext;
using TareaSemana4._2_MiguelOsorio_21551109.Models;

namespace TareaSemana4._2_MiguelOsorio_21551109.Controllers
{
    public class DMVDataContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Residencial> Residenciales { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Cancion> Canciones { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Profesional> Profesionales { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-ELBGGHK\SQLEXPRESS;DataBase=DMVDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //FluentApi
        {            
            modelBuilder.ApplyConfiguration(new VehiculoMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new CiudadMap());
            modelBuilder.ApplyConfiguration(new ResidencialMap());
            modelBuilder.ApplyConfiguration(new GradoMap());
            modelBuilder.ApplyConfiguration(new AlumnoMap());
            modelBuilder.ApplyConfiguration(new GeneroMap());
            modelBuilder.ApplyConfiguration(new CancionMap());
            modelBuilder.ApplyConfiguration(new StudentMap());
            modelBuilder.ApplyConfiguration(new CourseMap());
            modelBuilder.ApplyConfiguration(new StudentCourseMap());
            modelBuilder.ApplyConfiguration(new EmpresaMap());
            modelBuilder.ApplyConfiguration(new ProfesionalMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<TareaSemana4._2_MiguelOsorio_21551109.Models.Empresa> Empresa { get; set; }

        public DbSet<TareaSemana4._2_MiguelOsorio_21551109.Models.Profesional> Profesional { get; set; }
    }
}
