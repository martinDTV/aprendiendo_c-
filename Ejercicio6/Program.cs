


// BUCLES

// For

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"El valor de i es: {i}");
}


int contador = 0;


// While 

while (contador <= 5)
{
    Console.WriteLine($"Contador: {contador}");
    contador++;
}

// Do... While


int intento = 5;

do
{
    Console.WriteLine("Esto se ejecuta al menos una vez");
    intento++;
} while (intento < 5);


// foreach (Ideal para colecciones)

string[] frutas = { "manzada", "Pera", "Banana" };

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}


// SABER SI UN ALUMNO APROBO O REPROBO


Console.WriteLine("Ingrese una nota (0 - 100): ");

string entrada = Console.ReadLine();

int calificacion = int.Parse(entrada);

if (calificacion < 60)
{
    Console.WriteLine($"Usted Reprobo con una calificacion de: {calificacion}");
}
else if (calificacion <= 79)
{
    Console.WriteLine($"Usted aprobo con una calificacion de: {calificacion}");
}

else if (calificacion <= 100)
{
    Console.WriteLine($"Usted tuvo una nota excelente, con un promedio de: {calificacion}");
}

else
{
    Console.WriteLine("Eso no estaba esperado");
}