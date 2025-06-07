/*

AHORA VAMOS A UTILIZAR EN ESTE ARCHIVO TODO LO QUE SE ENCUENTRE EN "Estaticos.cs" AQUI ES DONDE INVOCAREMOS TODO

*/

double tempC = 45;
double tempF = Utilidades.ConvertirCelsiusAFahrenheit(tempC); // Mandamos a llamar sin necesidad de inicializar la clase llamamos a su funcion
// ConvertirCelsiusAFahrenheit
Console.WriteLine($"Temperatura en Fahrenheit: {tempF}"); // E imprimimos los resultados



// Usaremos el de la clase Matematica

int resultado = Matematica.Sumar(10, 10); // Sumaremos

Console.WriteLine(resultado);

int resta = Matematica.Restar(10, 5); // Restaremos

Console.WriteLine(resta);



// Vamos a usar la clase estatica que creamos en el otro archivo para corroborar el correo

Console.WriteLine("Ingrese su correo electronico: ");

string entradaCorreo = Console.ReadLine();


if (Validador.EsCorreoValido(entradaCorreo))
{
    Console.WriteLine("El correo es valido");

}
else
{
    Console.WriteLine("El correo no es valido");
}
