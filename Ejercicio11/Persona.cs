/*

Vamos a definir la clase persona para usarla en el archivo Program.cs

*/

public class Persona
{
    public string nombre;
    public int edad;

    public void Saludar()
    {
        Console.WriteLine($"Hola soy {nombre} y tengo {edad} años");
    }
}

// Ahora vamos a usar constructores que sirven para inicializar objetos al momento de crearlos.

// vamos a crear la clase vehiculo

public class Coche
{
    public string Marca;
    public string Color;

    public int Puertas;

    public int Velocidad;

    public Coche(string marca, string color, int puertas, int velocidad)
    {
        Marca = marca;
        Color = color;
        Puertas = puertas;
        Velocidad = velocidad;
    }

    public void InformacionCoche()
    {
        Console.WriteLine($"Este coche es de la marca {Marca}, es de color {Color}, cuenta con {Puertas} puertas y puede ir a una velocidad de {Velocidad} Km/h");
    }
}