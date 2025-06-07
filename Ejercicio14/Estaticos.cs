using System;
using System.Text.RegularExpressions;

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



¿Para qué sirven?

    - Funciones utilitarias o herramientas (conversores, validaciones, operaciones).

    - Métodos de acceso general, sin necesidad de estado o contexto del objeto.

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


// Vamos con el ejercicio que es para validar correos

public static class Validador
{
    public static bool EsCorreoValido(string correo)
    {
        /* 

        IsNullOrWhiteSpace en C# se usa para determinar si una cadena es nula (null), vacía o 
        contiene solo caracteres de espacio en blanco (como espacios, tabulaciones, nuevas líneas). 
        Es útil para validar cadenas, especialmente en casos donde un valor de entrada no debe estar vacío o consistir solo en espacios. 

        */

        if (string.IsNullOrWhiteSpace(correo)) return false;

        string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(correo, patron); // Esto es para saber si lo que recibimos como parametro cumple con el REGEX que tenemos
    }
}

// Nota para poder usar Regex, tenemos que importar

/* 

using System;
using System.Text.RegularExpressions;

*/