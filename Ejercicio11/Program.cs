/* 

Programación Orientada a Objetos (POO) en C#

La POO es el corazón del desarrollo moderno en C#, y aquí veremos los conceptos clave

*/


/* 

Clases y Objetos

Una clase define una plantilla. Un objeto es una instancia de esa clase.

*/

using System;

Persona persona = new Persona();
persona.nombre = "Martín";
persona.edad = 25;
persona.Saludar();


Coche coche = new Coche("Ferrari", "Rojo", 4, 60);

coche.InformacionCoche();