/*

Lectura y Escritura de Archivos con System.IO
📁 ¿Qué es System.IO?

Es el espacio de nombres que proporciona clases para manejar archivos, directorios, flujos de datos y más.
En C# puedes:

    - Leer archivos (File.ReadAllText, File.ReadAllLines)

    - Escribir archivos (File.WriteAllText, File.AppendAllText)

    - Comprobar si existen (File.Exists)

*/

// VAMOS A HACER UN EJERCICIO SIMPLE Y VAMOS A LEER UN ARCHIVO DE TEXTO 

// Vamos a combinarlo con el try-catch

/* 

Si el archivo ya existe, WriteAllText lo sobreescribe. Si quieres agregar texto sin borrar lo anterior, usa AppendAllText.

*/

using System.IO;


string ruta = "archivo.txt";

string mensaje = "Este es un mensaje guardado desde C#. Mi primer archivo guardado jejejeje";

File.WriteAllText(ruta, mensaje);
Console.WriteLine("Archivo creado exitosamente.");


// Agregar texto a un archivo

string rutaNuevaLista = "archivo.txt";
string nuevoTexto = "\nMi nueva linea";

File.AppendAllText(rutaNuevaLista, nuevoTexto);
Console.WriteLine("Texto agregado.");


// Vamos a corroborar que la ruta existe


string rutaNueva = "archivo.txt";

if (File.Exists(rutaNueva))
{
    string config = File.ReadAllText(rutaNueva);
}

else
{
    Console.WriteLine("⚠ El archivo de configuración no existe.");
}


/* 

 Casos donde try-catch es necesario
❌ 2. No tienes permisos para leer el archivo

Esto pasa cuando:

    El archivo está protegido.

    El usuario que ejecuta el programa no tiene permisos suficientes.

try
{
    string contenido = File.ReadAllText("C:\\Windows\\System32\\drivers\\etc\\hosts");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("🚫 No tienes permisos para acceder a este archivo.");
}

❌ 3. El archivo está en uso por otro proceso

Por ejemplo, otro programa lo está escribiendo.

try
{
    string contenido = File.ReadAllText("log.txt");
}
catch (IOException)
{
    Console.WriteLine("⚠ El archivo está siendo usado por otro proceso.");
}

❌ 4. La ruta del archivo es inválida o demasiado larga

try
{
    string contenido = File.ReadAllText("Z:\\carpeta_que_no_existe\\archivo.txt");
}
catch (DirectoryNotFoundException)
{
    Console.WriteLine("❌ La carpeta especificada no existe.");
}
catch (PathTooLongException)
{
    Console.WriteLine("❌ La ruta del archivo es demasiado larga.");
}

❌ 5. Error inesperado (siempre tener un catch general)

catch (Exception ex)
{
    Console.WriteLine($"❌ Error inesperado: {ex.Message}");
}


*/