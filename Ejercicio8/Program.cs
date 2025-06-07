// VAMOS A VER FUNCIONES



// una funcion sencilla solo para saludar
static void Saludar(string nombre)
{
    Console.WriteLine($"Hola {nombre}");
}

Saludar("Martin");



// funcion para sumar dos numeros (el poner int en ves de void nos esta dicienod que vamos a retornar un entero)

static int SumarNumeros(int a, int b)
{
    return a + b;
}


/* 

void  -----	No retorna nada
int ---- 	Retorna número entero
double ----	Retorna decimal
bool ---	Retorna verdadero/falso
string  ---	Retorna texto

*/

int suma = SumarNumeros(24, 45);
Console.WriteLine($"La suma es: {suma}");


// C# permite declarar varios métodos con el mismo nombre, siempre y cuando tengan diferentes parámetros

static double sumar(double a, double b) => a + b;

double sumarDouble = sumar(34.43, 35.34);

Console.WriteLine($"La suma es: {sumarDouble}");



//  Paso de parámetros por valor y por referencia

static void Incrementar(ref int numero)
{
    numero++;
}

int x = 5;

Incrementar(ref x);

Console.WriteLine(x);

// Esto hace que si le pasamos como parametro la variable "x", la funcion lo que hace es sumar 1 a su valor, pero en este caso, el valor se le suma 
// a la variable x, sin necesidad de retornar nada en este caso es como hacer una referencia, para que la variable que se le pase a la funcion haga lo que dice 
// la funcion (en este caso sumar uno a su valor y no tendriamos que retorna nada ya que esto se le suma directamente a la variable).


// Vamos a pedirle al usuario dos numeros y le preguntaremos que operacion quiere realizar (+, -, *, /). 


static double SumaNumeros(double a, double b) => a + b;
static double RestarNumeros(double a, double b) => a - b;
static double MultiplicarNumeros(double a, double b) => a * b;
static double DividirNumeros(double a, double b) => a / b;


Console.WriteLine("Ingrese el primer numero: ");

double numeroUno = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");

double numeroDos = double.Parse(Console.ReadLine());


Console.WriteLine("Ingrese la operacion que desea realizar (+, -, *, /): ");

char operacion = Console.ReadLine()[0];

double respuesta;

switch (operacion)
{
    case '+':
        respuesta = SumaNumeros(numeroUno, numeroDos);
        Console.WriteLine($"El resultado de la suma es: {respuesta}");
        break;

    case '-':
        respuesta = RestarNumeros(numeroUno, numeroDos);
        Console.WriteLine($"El resultado de la resta es: {respuesta}");
        break;

    case '*':
        respuesta = MultiplicarNumeros(numeroUno, numeroDos);
        Console.WriteLine($"El resultado de la multiplicación es: {respuesta}");
        break;

    case '/':
        respuesta = DividirNumeros(numeroUno, numeroDos);
        Console.WriteLine($"El resultado de la división es: {respuesta}");
        break;

    default:
        Console.WriteLine("Esa opción no es correcta");
        break;
}
