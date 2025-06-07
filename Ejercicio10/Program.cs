/* 
Estructuras de datos dinámicas: List<T> y Dictionary<TKey, TValue>

Estas estructuras son fundamentales cuando necesitas trabajar con colecciones dinámicas y más potentes que los arrays.

*/

using System.Collections.Generic;

List<string> tareas = new List<string>();

tareas.Add("Estudiar C#");
tareas.Add("Practicas bucles");
tareas.Add("Hacer ejercicios");

foreach (string tarea in tareas)
{
    Console.WriteLine($"📌 {tarea}");
}


// Dictionary<TKey, TValue> — Diccionario (clave-valor)


Dictionary<string, int> edades = new Dictionary<string, int>()
{
    {"Martin", 20},
    {"Perlile", 21},
    {"Molly", 4}
};


foreach (KeyValuePair<string, int> par in edades)
{
    Console.WriteLine($"Nombre: {par.Key}, Edad: {par.Value}");
}


Console.WriteLine(new string('-', 54));

// usando var en ves ed KeyValuePair

foreach (var par in edades)
{
    Console.WriteLine($"Nombre: {par.Key}, Edad: {par.Value}");
}


/*  
Crea un programa que:

    Te permita registrar varios productos junto con su precio.

    Use un Dictionary<string, double> para almacenar los datos.

    Muestre la lista completa de productos y sus precios.

    Calcule y muestre el precio total de todos los productos registrados.
 */


Console.WriteLine("Hola, ¿Cuantos productos desea agregar?");

int respuestaProductos = int.Parse(Console.ReadLine());

Dictionary<string, double> diccionarioProductos = new Dictionary<string, double>();

for (int i = 0; i < respuestaProductos; i++)
{
    Console.WriteLine($"Escriba el Nombre del producto {i + 1}: ");
    string nombreProducto = Console.ReadLine();

    Console.WriteLine("Escriba el precio para el producto: ");
    double precioProducto = double.Parse(Console.ReadLine());

    diccionarioProductos[nombreProducto] = precioProducto;
}


Console.WriteLine(new string('-', 54));

Console.WriteLine("Estos son los productos que se registraron con sus respectivos precios!");

foreach (var producto in diccionarioProductos)
{
    Console.WriteLine($"Producto: {producto.Key}, tiene un precio de: {producto.Value}");
}

Console.WriteLine(new string('-', 54));

double sumaTotal = 0.0;

foreach (var prod in diccionarioProductos)
{
    sumaTotal += prod.Value;
}

Console.WriteLine($"La suma total de los productos es: {sumaTotal}");