func @_TareaSemana4._2_MiguelOsorio_21551109.Controllers.DMVDataContext.OnConfiguring$Microsoft.EntityFrameworkCore.DbContextOptionsBuilder$(none) -> () loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :25 :8) {
^entry (%_optionsBuilder : none):
%0 = cbde.alloca none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :25 :46)
cbde.store %_optionsBuilder, %0 : memref<none> loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :25 :46)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :27 :12) // Not a variable of known type: optionsBuilder
%2 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :27 :40) // @"Server=DESKTOP-ELBGGHK\SQLEXPRESS;DataBase=DMVDB;Trusted_Connection=True;" (StringLiteralExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :27 :12) // optionsBuilder.UseSqlServer(@"Server=DESKTOP-ELBGGHK\SQLEXPRESS;DataBase=DMVDB;Trusted_Connection=True;") (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
func @_TareaSemana4._2_MiguelOsorio_21551109.Controllers.DMVDataContext.OnModelCreating$Microsoft.EntityFrameworkCore.ModelBuilder$(none) -> () loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :30 :8) {
^entry (%_modelBuilder : none):
%0 = cbde.alloca none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :30 :48)
cbde.store %_modelBuilder, %0 : memref<none> loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :30 :48)
br ^0

^0: // SimpleBlock
%1 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :32 :12) // Not a variable of known type: modelBuilder
%2 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :32 :44) // new VehiculoMap() (ObjectCreationExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :32 :12) // modelBuilder.ApplyConfiguration(new VehiculoMap()) (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :33 :12) // Not a variable of known type: modelBuilder
%5 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :33 :44) // new CategoriaMap() (ObjectCreationExpression)
%6 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :33 :12) // modelBuilder.ApplyConfiguration(new CategoriaMap()) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :34 :12) // Not a variable of known type: modelBuilder
%8 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :34 :44) // new CiudadMap() (ObjectCreationExpression)
%9 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :34 :12) // modelBuilder.ApplyConfiguration(new CiudadMap()) (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :35 :12) // Not a variable of known type: modelBuilder
%11 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :35 :44) // new ResidencialMap() (ObjectCreationExpression)
%12 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :35 :12) // modelBuilder.ApplyConfiguration(new ResidencialMap()) (InvocationExpression)
%13 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :36 :12) // Not a variable of known type: modelBuilder
%14 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :36 :44) // new GradoMap() (ObjectCreationExpression)
%15 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :36 :12) // modelBuilder.ApplyConfiguration(new GradoMap()) (InvocationExpression)
%16 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :37 :12) // Not a variable of known type: modelBuilder
%17 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :37 :44) // new AlumnoMap() (ObjectCreationExpression)
%18 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :37 :12) // modelBuilder.ApplyConfiguration(new AlumnoMap()) (InvocationExpression)
%19 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :38 :12) // Not a variable of known type: modelBuilder
%20 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :38 :44) // new GeneroMap() (ObjectCreationExpression)
%21 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :38 :12) // modelBuilder.ApplyConfiguration(new GeneroMap()) (InvocationExpression)
%22 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :39 :12) // Not a variable of known type: modelBuilder
%23 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :39 :44) // new CancionMap() (ObjectCreationExpression)
%24 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :39 :12) // modelBuilder.ApplyConfiguration(new CancionMap()) (InvocationExpression)
%25 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :40 :12) // Not a variable of known type: modelBuilder
%26 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :40 :44) // new StudentMap() (ObjectCreationExpression)
%27 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :40 :12) // modelBuilder.ApplyConfiguration(new StudentMap()) (InvocationExpression)
%28 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :41 :12) // Not a variable of known type: modelBuilder
%29 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :41 :44) // new CourseMap() (ObjectCreationExpression)
%30 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :41 :12) // modelBuilder.ApplyConfiguration(new CourseMap()) (InvocationExpression)
%31 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :42 :12) // Not a variable of known type: modelBuilder
%32 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :42 :44) // new StudentCourseMap() (ObjectCreationExpression)
%33 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :42 :12) // modelBuilder.ApplyConfiguration(new StudentCourseMap()) (InvocationExpression)
%34 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :43 :12) // Not a variable of known type: modelBuilder
%35 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :43 :44) // new EmpresaMap() (ObjectCreationExpression)
%36 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :43 :12) // modelBuilder.ApplyConfiguration(new EmpresaMap()) (InvocationExpression)
%37 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :44 :12) // Not a variable of known type: modelBuilder
%38 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :44 :44) // new ProfesionalMap() (ObjectCreationExpression)
%39 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :44 :12) // modelBuilder.ApplyConfiguration(new ProfesionalMap()) (InvocationExpression)
%40 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :45 :12) // base (BaseExpression)
%41 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :45 :33) // Not a variable of known type: modelBuilder
%42 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\DataContext\\DMVDataContext.cs" :45 :12) // base.OnModelCreating(modelBuilder) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
