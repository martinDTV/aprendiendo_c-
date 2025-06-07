Console.Write("¿Cuántas calificaciones vas a ingresar? ");
        int total = int.Parse(Console.ReadLine());

        int suma = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 1; i <= total; i++)
        {
            Console.Write($"Calificación #{i}: ");
            int calificacion = int.Parse(Console.ReadLine());

            suma += calificacion;

            if (calificacion > max)
                max = calificacion;

            if (calificacion < min)
                min = calificacion;
        }

        double promedio = (double)suma / total;

        Console.WriteLine($"\nPromedio: {promedio}");
        Console.WriteLine($"Mayor calificación: {max}");
        Console.WriteLine($"Menor calificación: {min}");