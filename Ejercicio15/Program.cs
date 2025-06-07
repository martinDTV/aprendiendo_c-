/* 

Manejo de Errores en C# (try, catch, finally)

🧠 ¿Por qué se usa?

Para prevenir que tu programa se caiga cuando ocurre un error (por ejemplo, al dividir por cero o convertir texto a número incorrectamente).


try
{
    // Código que podría lanzar una excepción
}
catch (TipoDeExcepcion ex)
{
    // Qué hacer si ocurre ese error
}
finally
{
    // Opcional: código que siempre se ejecuta, con o sin error
}

💡 Consejos

    - Siempre captura primero las excepciones más específicas.

    - Usa Exception al final para manejar cualquier otro error.

    - El bloque finally se ejecuta siempre, incluso si hay un return o una excepción.

*/

try
{
    Console.Write("Ingrese un número: ");
    int numero = int.Parse(Console.ReadLine());

    Console.Write("Ingrese otro número: ");
    int divisor = int.Parse(Console.ReadLine());

    int resultado = numero / divisor;
    Console.WriteLine($"Resultado: {resultado}");
}
catch (FormatException)
{
    Console.WriteLine("❌ Debes ingresar un número válido.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("❌ No se puede dividir entre cero.");
}
catch (Exception ex)
{
    Console.WriteLine($"❌ Ocurrió un error inesperado: {ex.Message}");
}
finally
{
    Console.WriteLine("✔ Operación finalizada.");
}