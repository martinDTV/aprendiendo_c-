/* 

Vamos a implementar las clases que heredan desde la clase animal

*/


Perro perro = new Perro();

perro.Nombre = "Spike";
perro.Comer();
perro.Ladrar();

Gato gato = new Gato();

gato.Nombre = "Tonchi";
gato.Comer();
gato.Maullar();


// Ahora vamos a crear objetos partiendo de la clase Vehiculo

Vehiculo[] vehiculos = new Vehiculo[3]; // Esto crea un array de tipo Vehiculo con un tamaño de 3

vehiculos[0] = new Vehiculo { Marca = "Generico" };
vehiculos[1] = new Automovil { Marca = "Nissan" };
vehiculos[2] = new Bicicleta { Marca = "Benotto" };


foreach (Vehiculo vehiculo in vehiculos)
{
    Console.WriteLine(new string('-', 54));
    Console.WriteLine($"{vehiculo.Marca}");
    vehiculo.Avanzar();
}