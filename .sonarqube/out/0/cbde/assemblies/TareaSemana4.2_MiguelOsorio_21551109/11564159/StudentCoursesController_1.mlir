// Skipping function GetStudentCourses(), it contains poisonous unsupported syntaxes

// Skipping function GetStudentCourse(i32), it contains poisonous unsupported syntaxes

// Skipping function PostStudentCourse(none), it contains poisonous unsupported syntaxes

// Skipping function DeleteStudentCourse(i32), it contains poisonous unsupported syntaxes

// Skipping function StudentCourseExists(i32), it contains poisonous unsupported syntaxes

// Skipping function StudentExists(i32), it contains poisonous unsupported syntaxes

// Skipping function CourseExists(i32), it contains poisonous unsupported syntaxes

func @_TareaSemana4._2_MiguelOsorio_21551109.Controllers.StudentCoursesController.CountCourses$int$(i32) -> i32 loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\StudentCoursesController.cs" :111 :8) {
^entry (%_id : i32):
%0 = cbde.alloca i32 loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\StudentCoursesController.cs" :111 :33)
cbde.store %_id, %0 : memref<i32> loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\StudentCoursesController.cs" :111 :33)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\StudentCoursesController.cs" :113 :19) // Not a variable of known type: _context
%2 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\StudentCoursesController.cs" :113 :19) // _context.StudentCourses (SimpleMemberAccessExpression)
%3 = cbde.unknown : i32 loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\StudentCoursesController.cs" :113 :19) // _context.StudentCourses.Count() (InvocationExpression)
return %3 : i32 loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\StudentCoursesController.cs" :113 :12)

^1: // ExitBlock
cbde.unreachable

}
