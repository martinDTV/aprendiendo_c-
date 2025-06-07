/*

Vamos a ver sobre las interfaces

*/

/*

¿Qué es una interfaz?

Una interfaz define un contrato: un conjunto de métodos (y propiedades) que una clase debe implementar, pero sin darles implementación.

Es como decir: “Cualquier clase que use esta interfaz debe tener estos métodos”.

*/


/*

¿Para qué sirven las interfaces?

Separar la declaración de lo que hace una clase de su implementación concreta.

Implementar polimorfismo sin herencia (una clase puede implementar varias interfaces, pero no heredar de varias clases).

Muy usadas en arquitectura limpia, testing, y patrones como Dependency Injection.

*/


/* 

¿Qué puedes definir en una interfaz en C#?

Una interfaz puede contener:

    - Métodos (sin implementación, o con default implementación desde C# 8.0).

    - Propiedades (lo más cercano a los atributos).

    - Eventos.

    - Indexadores.

*/

public interface ITrabajable
{
    void Trabajar(); // Ahora cualquier clase que “implementa” esta interfaz debe definir el método Trabajar.
}


//  Implementando la interfaz en varias clases

public class Empleado : ITrabajable
{
    public void Trabajar()
    {
        Console.WriteLine("El empleado esta trabajando");
    }
}

public class Robot : ITrabajable
{
    public void Trabajar()
    {
        Console.WriteLine("El robot esta ensamblando piezas");
    }
}



// Vamos a usar las propiedades (Esto en lugar de atributos)

public interface IPersona
{
    string Nombre { get; set; }
    int Edad { get; set; }

    void Saludar();
}


public class Estudiante : IPersona
{
    public string Nombre { get; set; } // Recordar que si solo pongo string Nombre { get; set; } e intento acceder me dara un error ya que
    // Las variables no son de acceso publico y no puedo acceder a ellas.
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola soy {Nombre} y tengo {Edad} años");
    }
}