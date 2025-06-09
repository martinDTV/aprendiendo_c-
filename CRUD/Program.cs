/*

Ejercicio: CRUD de usuarios (Consola C#)
🎯 Objetivo:

Simular un sistema de gestión de usuarios desde consola, con las siguientes operaciones:

    Crear usuario

    Listar usuarios

    Buscar usuario por ID

    Actualizar usuario

    Eliminar usuario

    Salir

🧠 Requisitos técnicos a cubrir:

    Uso de listas (List<User>)

    Uso de clases y métodos

    LINQ para buscar y filtrar

    Control de errores (try/catch)

    Uso de menús por consola

    Uso de Console.ReadLine, int.Parse, Guid si deseas IDs únicos

*/ 
using System;
using System.Collections.Generic;


bool sistemaEnAccion = true;

List<Usuario> usuarios = new List<Usuario>();

while (sistemaEnAccion)
{
    Console.WriteLine("=== Menú de Usuarios ===");
    Console.WriteLine("1. Crear usuario");
    Console.WriteLine("2. Listar usuarios");
    Console.WriteLine("3. Buscar usuario por ID");
    Console.WriteLine("4. Actualizar usuario");
    Console.WriteLine("5. Eliminar usuario");
    Console.WriteLine("6. Salir");

    int opcionUsuario = int.Parse(Console.ReadLine());

    switch (opcionUsuario)
    {
        case 1:
            int idUsuario = 1;

            Usuario usuario = new Usuario();

            Console.WriteLine("Escriba el nombre del usuario: ");
            string nombreUsuario = Console.ReadLine();

            Console.WriteLine("Escriba el correo del usuario: ");
            string correoUsuario = Console.ReadLine();

            ResultadoUsuario response = Usuario.CreateUser(usuarios, idUsuario, nombreUsuario, correoUsuario);

            if (response.Status)
            {
                Usuario user = new Usuario()
                {
                    Id = response.Id,
                    Nombre = response.Nombre,
                    Email = response.Correo,
                };

                usuarios.Add(user);

                Console.WriteLine("Usuario creado exitosamente");
                break;
            }

            break;

        case 2:
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Estos son los usuarios: ");

            foreach (var us in usuarios)
            {
                Console.WriteLine($"{us.Nombre} - {us.Email}");
            }

            Console.WriteLine(new string('-', 100));

            break;

        default:
            Console.WriteLine("No tenemos es opcion");
            break;
    }
}