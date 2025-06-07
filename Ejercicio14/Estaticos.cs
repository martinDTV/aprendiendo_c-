/* 

Vamos a ver los metodos y clases estaticas


¿Qué significa “estático” (static)?

    Un método o propiedad static pertenece a la clase, no a una instancia (objeto) de la clase.

    Puedes llamarlo sin crear un objeto.

    Es parecido a cuando usas Math.round() o Math.sqrt() en otros lenguajes.

*/

/* 

🚫 Importante:

    No puedes crear una instancia de una clase estática.

    No puedes usar this dentro de métodos estáticos.

    Las clases estáticas no pueden heredar ni ser heredadas.

*/

// EJEMPLO DE METODO ESTATICO

public class Utilidades
{
    public static double ConvertirCelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}


// Vamos a realizar una clase estatica completa

// Si todos los métodos son static, puedes hacer la clase completa static:


public static class Matematica
{
    public static int Sumar(int a, int b) => a + b;
    public static int Restar(int a, int b) => a - b;
}