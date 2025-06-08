/*

Introducción a LINQ (Language Integrated Query)

LINQ te permite consultar y transformar colecciones de datos (listas, arreglos, diccionarios, etc.) de forma declarativa y elegante, similar a SQL.
✅ ¿Por qué usar LINQ?

    Es más legible y conciso.

    Permite hacer filtros, ordenamientos, agrupaciones, proyecciones.

    Funciona con listas (List<T>), arrays, diccionarios, XML, bases de datos, etc.


| Método                | Descripción                             |
| --------------------- | --------------------------------------- |
| `Where()`             | Filtra elementos                        |
| `Select()`            | Proyecta o transforma los datos         |
| `OrderBy()`           | Ordena ascendente                       |
| `OrderByDescending()` | Ordena descendente                      |
| `FirstOrDefault()`    | Devuelve el primer elemento o null      |
| `Any()`               | Verifica si hay al menos uno que cumple |
| `Count()`             | Cuenta cuántos cumplen una condición    |


*/

using System;
using System.Linq;
using System.Collections.Generic;


List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

var pares = numeros.Where(n => n % 2 == 0);

foreach (int par in pares)
{
    Console.WriteLine(par);
}


//  Obtener nombres que empiezan con "A"


Console.WriteLine(new string('-', 54));


List<string> nombres = new List<string> { "Martin", "Perla", "ana", "Antonio", "Andres", "Molly", "Luis", "Karen" };

var nombresConA = nombres.Where(nombre => nombre.StartsWith("A", StringComparison.OrdinalIgnoreCase));

// con StringComparison.OrdinalIgnoreCase le dicemos al método que ignore las diferencias entre mayúsculas y minúsculas.

foreach (var nombre in nombresConA)
{
    Console.WriteLine(nombre);
}


//  Ordenar una lista de enteros

List<int> edades = new List<int> { 20, 50};

var ordenadas = edades.OrderBy(e => e);

foreach (var edad in ordenadas)
{
    Console.WriteLine(edad);
}


/* 

🧪 Ejercicio: Filtrar y ordenar una lista de productos
🎯 Requisitos

Dado una lista de productos, queremos:

    Filtrar los productos cuyo precio sea mayor a 100.

    Ordenarlos por nombre alfabéticamente.

    Mostrar nombre y precio de cada uno.

*/

Console.WriteLine(new string('-', 100));

List<Producto> productos = new List<Producto>
{
    new Producto { Nombre = "Laptop", Precio = 1500 },
    new Producto { Nombre = "Mouse", Precio = 25 },
    new Producto { Nombre = "Monitor", Precio = 300 },
    new Producto { Nombre = "Teclado", Precio = 75 },
    new Producto { Nombre = "Celular", Precio = 800 }
};

var productosOrdenados = productos.Where(prod => prod.Precio > 100).OrderBy(p => p.Nombre);


foreach (var producto in productosOrdenados)
{
    Console.WriteLine($"{producto.Nombre} - {producto.Precio}");
}