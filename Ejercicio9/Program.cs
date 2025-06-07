// VAMOS A APRENDER SOBRE ARRAYS Y COLECCIONES
using System.Collections.Generic;

// ARRAYS 


int[] numeros = new int[3]; // Esto es un array de 3 enteros

numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 30;


// Tambien podemos inicializarlos directamente

int[] edades = { 35, 30, 20, 40 };




// Recorre una lista completa

for (int i = 0; i < edades.Length; i++)
{
    Console.WriteLine(edades[i]);
}


// LIST A diferencia de los arrays, las listas son dinámicas (pueden crecer y decrecer).

/*

Métodos útiles de List<T>:

    Add(valor) – agrega un elemento.

    Remove(valor) – elimina por valor.

    Contains(valor) – verifica si existe.

    Count – devuelve cuántos elementos hay.

*/

List<string> frutas = new List<string>();

frutas.Add("Manzana");
frutas.Add("Banana");
frutas.Add("Pera");

foreach (string fruta in frutas)
{
    Console.WriteLine($"Fruta: {fruta}");
}


/* 

Crea un programa que:

    Pida al usuario cuántas calificaciones va a ingresar.

    Use un array para almacenar las calificaciones.

    Calcule el promedio de todas las calificaciones.

    Muestre el promedio al final.

*/


Console.WriteLine("Cuantas calificaciones desea ingresar:");

int entradaCalificaciones = int.Parse(Console.ReadLine());


double[] calificaciones = new double[entradaCalificaciones];


for (int i = 0; i < calificaciones.Length; i++)
{
    Console.WriteLine($"Ingrese la calificacion {i + 1}");
    double calificacionEntrada = double.Parse(Console.ReadLine());
    calificaciones[i] = calificacionEntrada;
}

double suma = 0;

foreach (double calificacion in calificaciones)
{
    suma += calificacion;
}

double promedio = suma / entradaCalificaciones;

Console.WriteLine($"El promedio es: {promedio}");