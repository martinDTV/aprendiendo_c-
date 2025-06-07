/*   

Vamos a ver herencia y vamos a crear la clase de animal

*/


public class Animal // clase padre
{
    public string Nombre { get; set; }

    public void Comer()
    {
        Console.WriteLine($"{Nombre} esta comiendo");
    }

    public void Dormir()
    {
        Console.WriteLine($"{Nombre} esta durmiendo");
    }
}


// Vamos a hacer herencia creando la clase Perro que va a heredar de la clase Animal


public class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} dice: ¡Guau!");
    }
}

// Ahora crearemos la clase Gato que igual heredara de Animal

public class Gato : Animal
{
    public void Maullar()
    {
        Console.WriteLine($"{Nombre} dice: Miau.");
    }
}


/* 

Vamos a empezar con el polimorfismo

¿Qué es el polimorfismo?

Polimorfismo significa “muchas formas”. En C#, permite que un mismo método se comporte de manera diferente dependiendo del tipo de objeto 
que lo llame.

Hay dos tipos:
----------------------------------------------------------------------------------------------------------------
    Tipo de polimorfismo   |	     ¿Cómo se usa?                                                             |
----------------------------------------------------------------------------------------------------------------
    Sobrecarga	           |         Mismo nombre de método, diferente firma.                                  | 
    Sobrescritura	       |         Una subclase redefine el comportamiento de un método de la clase padre.   |
----------------------------------------------------------------------------------------------------------------
*/


// Enfocándonos en la sobrescritura de métodos (override)

public class Vehiculo
{
    public string Marca { get; set; }

    public virtual void Avanzar()
    {
        Console.WriteLine("Ruuuuuun, el vehiculo esta avanzando");
    }
}


public class Automovil : Vehiculo
{
    public override void Avanzar()
    {
        Console.WriteLine("El vehiculo esta avanzando");
    }
}

public class Bicicleta : Vehiculo
{
    public override void Avanzar()
    {
        Console.WriteLine("La bicicleta esta avanzado!");
    }
}