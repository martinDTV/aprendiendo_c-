/* 

SI ACABAN DE ABRIR ESTE ARCHIVO EL PRIMER EJEMPLO ESTA EN EL ARCHIVO "Interfaces.cs", AQUI SOLO SE APLICARAN LOS EJEMPLOS DE MAIN
LA DESCRIPCION DE QUE SON LAS INTERFACES ESTAN EN DICHO ARCHIVO

*/

List<ITrabajable> trabajadores = new List<ITrabajable>();

trabajadores.Add(new Empleado());
trabajadores.Add(new Robot());

foreach (var trabajador in trabajadores)
{
    trabajador.Trabajar();
}

Estudiante estudiante = new Estudiante("Martin", 23);

estudiante.Saludar();