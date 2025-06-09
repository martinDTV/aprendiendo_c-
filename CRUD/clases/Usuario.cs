
// Vamos a crear la clase de usuario
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class ResultadoUsuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public bool Status { get; set; }
}


public class Usuario
{
    public int Id { set; get; }
    public string Nombre { set; get; } = string.Empty;
    public string Email { set; get; }


    public static bool ValidarCorreo(string correo)
    {
        string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(correo, patron);
    }


    public static ResultadoUsuario CreateUser(List<Usuario> usuarios, int id, string nombre, string email)
    {
        ResultadoUsuario resultado = new ResultadoUsuario
        {
            Id = 0,
            Nombre = "",
            Correo = "",
            Status = false

        };

        if (ValidarCorreo(email))
        {
            var usuarioEncontrado = usuarios.FirstOrDefault(usuario => usuario.Email == email);

            if (usuarioEncontrado != null)
            {
                Console.WriteLine("El correo ya esta en uso!");

                return resultado;
            }

            resultado.Id = id;
            resultado.Nombre = nombre;
            resultado.Correo = email;
            resultado.Status = true;

            return resultado;

        }
        Console.WriteLine("Correo no válido");
        return resultado;
    }

}