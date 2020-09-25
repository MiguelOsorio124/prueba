using Microsoft.EntityFrameworkCore.Migrations;

namespace TareaSemana4._2_MiguelOsorio_21551109.Migrations
{
    public partial class CrearDBTarea42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Categoria",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(nullable: true),
                    DescripcionCategoria = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudad",
                schema: "dbo",
                columns: table => new
                {
                    IdCiudad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCiudad = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.IdCiudad);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                schema: "dbo",
                columns: table => new
                {
                    IdCourse = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCourse = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.IdCourse);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                schema: "dbo",
                columns: table => new
                {
                    IdEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "varchar(50)", nullable: false),
                    MaxEmpleadosEmpresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.IdEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                schema: "dbo",
                columns: table => new
                {
                    IdGenero = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGenero = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "Grado",
                schema: "dbo",
                columns: table => new
                {
                    IdGrado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreGrado = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grado", x => x.IdGrado);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "dbo",
                columns: table => new
                {
                    IdStudent = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreStudent = table.Column<string>(type: "varchar(50)", nullable: false),
                    EdadStudent = table.Column<int>(type: "int", nullable: false),
                    EstadoStudent = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.IdStudent);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVehiculo = table.Column<string>(type: "varchar(50)", nullable: false),
                    MarcaVehiculo = table.Column<string>(type: "varchar(50)", nullable: false),
                    AñoVehiculo = table.Column<int>(type: "int", nullable: false),
                    ColorVehiculo = table.Column<string>(type: "varchar(50)", nullable: false),
                    IdCategoria = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalSchema: "dbo",
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Residencial",
                schema: "dbo",
                columns: table => new
                {
                    IdResidencial = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreResidencial = table.Column<string>(type: "varchar(50)", nullable: false),
                    IdCiudad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residencial", x => x.IdResidencial);
                    table.ForeignKey(
                        name: "FK_Residencial_Ciudad_IdCiudad",
                        column: x => x.IdCiudad,
                        principalSchema: "dbo",
                        principalTable: "Ciudad",
                        principalColumn: "IdCiudad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profesional",
                schema: "dbo",
                columns: table => new
                {
                    IdProfesional = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreProfesional = table.Column<string>(type: "varchar(50)", nullable: false),
                    EdadProfesional = table.Column<int>(type: "int", nullable: false),
                    EstadoProfesional = table.Column<bool>(type: "bit", nullable: false),
                    IdEmpresa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesional", x => x.IdProfesional);
                    table.ForeignKey(
                        name: "FK_Profesional_Empresa_IdEmpresa",
                        column: x => x.IdEmpresa,
                        principalSchema: "dbo",
                        principalTable: "Empresa",
                        principalColumn: "IdEmpresa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cancion",
                schema: "dbo",
                columns: table => new
                {
                    IdCancion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCancion = table.Column<string>(type: "varchar(50)", nullable: false),
                    IdGenero = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancion", x => x.IdCancion);
                    table.ForeignKey(
                        name: "FK_Cancion_Genero_IdGenero",
                        column: x => x.IdGenero,
                        principalSchema: "dbo",
                        principalTable: "Genero",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alumno",
                schema: "dbo",
                columns: table => new
                {
                    IdAlumno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAlumno = table.Column<string>(type: "varchar(50)", nullable: false),
                    IdGrado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumno", x => x.IdAlumno);
                    table.ForeignKey(
                        name: "FK_Alumno_Grado_IdGrado",
                        column: x => x.IdGrado,
                        principalSchema: "dbo",
                        principalTable: "Grado",
                        principalColumn: "IdGrado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                schema: "dbo",
                columns: table => new
                {
                    IdStudentCourse = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdStudent = table.Column<int>(nullable: false),
                    IdCourse = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => x.IdStudentCourse);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Course_IdCourse",
                        column: x => x.IdCourse,
                        principalSchema: "dbo",
                        principalTable: "Course",
                        principalColumn: "IdCourse",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Student_IdStudent",
                        column: x => x.IdStudent,
                        principalSchema: "dbo",
                        principalTable: "Student",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumno_IdGrado",
                schema: "dbo",
                table: "Alumno",
                column: "IdGrado");

            migrationBuilder.CreateIndex(
                name: "IX_Cancion_IdGenero",
                schema: "dbo",
                table: "Cancion",
                column: "IdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_Profesional_IdEmpresa",
                schema: "dbo",
                table: "Profesional",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Residencial_IdCiudad",
                schema: "dbo",
                table: "Residencial",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_IdCourse",
                schema: "dbo",
                table: "StudentCourse",
                column: "IdCourse");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_IdStudent",
                schema: "dbo",
                table: "StudentCourse",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_IdCategoria",
                schema: "dbo",
                table: "Vehiculo",
                column: "IdCategoria");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumno",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Cancion",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Profesional",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Residencial",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "StudentCourse",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Vehiculo",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Grado",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Genero",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Empresa",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Ciudad",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Course",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Student",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Categoria",
                schema: "dbo");
        }
    }
}
