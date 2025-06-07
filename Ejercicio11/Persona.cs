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

/* 

Encapsulamiento con propiedades (get / set)

*/

/* 

Es un principio de la programación orientada a objetos que consiste en ocultar los datos internos de una clase y controlar 
el acceso a ellos mediante propiedades.

*/

public class Producto
{
    private string nombre;
    private double precio;


    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    public double Precio
    {
        get { return precio; }
        set
        {
            if (value >= 0)
            {
                precio = value;
            }
            else
            {
                Console.WriteLine("El precio no puede ser negativo!");
            }
        }
    }

    public void MostarInfo()
    {
        Console.WriteLine($"Producto: {Nombre} - Precio: {Precio}");
    }

}