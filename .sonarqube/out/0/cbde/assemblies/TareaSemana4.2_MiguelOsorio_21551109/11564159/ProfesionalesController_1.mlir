// Skipping function GetProfesionales(), it contains poisonous unsupported syntaxes

// Skipping function GetProfesional(i32), it contains poisonous unsupported syntaxes

// Skipping function PutProfesional(i32, none), it contains poisonous unsupported syntaxes

// Skipping function PostProfesional(none), it contains poisonous unsupported syntaxes

// Skipping function DeleteProfesional(i32), it contains poisonous unsupported syntaxes

// Skipping function ProfesionalExists(i32), it contains poisonous unsupported syntaxes

// Skipping function EmpresaExists(i32), it contains poisonous unsupported syntaxes

func @_TareaSemana4._2_MiguelOsorio_21551109.Controllers.ProfesionalesController.CountProfesionales$int$(i32) -> i32 loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\ProfesionalesController.cs" :150 :8) {
^entry (%_id : i32):
%0 = cbde.alloca i32 loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\ProfesionalesController.cs" :150 :39)
cbde.store %_id, %0 : memref<i32> loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\ProfesionalesController.cs" :150 :39)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\ProfesionalesController.cs" :152 :19) // Not a variable of known type: _context
%2 = cbde.unknown : none loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\ProfesionalesController.cs" :152 :19) // _context.Profesionales (SimpleMemberAccessExpression)
%3 = cbde.unknown : i32 loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\ProfesionalesController.cs" :152 :19) // _context.Profesionales.Count() (InvocationExpression)
return %3 : i32 loc("C:\\Users\\Osorio\\Desktop\\Miguel Osorio Ceutec\\III 2020\\Ingenieria de Software II\\Semana 4\\TareaSemana4.2_MiguelOsorio_21551109\\Controllers\\ProfesionalesController.cs" :152 :12)

^1: // ExitBlock
cbde.unreachable

}
