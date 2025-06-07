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