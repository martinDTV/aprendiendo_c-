// Calcular la edad


// PEDIREMOS AL USUARIO SU NOMBRE Y AÑO DE NACIMIENTO. CALCULAREMOS LA EDAD Y LA MOSTRAREMOS EN UN MENSAJE PERSONALIZADO


Console.WriteLine("¿Como te llamas?: ");
string nombre = Console.ReadLine();

// Pediremos el año en el que nacio
Console.WriteLine("¿En que año naciste?: ");
string entrada = Console.ReadLine();

int anioNacimiento = int.Parse(entrada);


int AnioActual = DateTime.Now.Year;
int edad = AnioActual - anioNacimiento;


Console.WriteLine($"Hola {nombre}, tienes {edad} años");