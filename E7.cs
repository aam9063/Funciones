/*
 * Calendario del Siglo:

Vamos a ver como podemos genera si queremos el calendario para los años que queramos

Primero vamoa ver como seria el bucle
*/

using System;

public class Program
{
    static void Main()
    {
        Console.Write("Año Inicial: ");
        int añoInicial = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Año Final: ");
        int añoFinal = int.Parse(Console.ReadLine() ?? "0");

        if (añoFinal < añoInicial)
            Console.WriteLine("El año Final tiene que ser mayor que año Inicial");
        else
        {
            for (int año = añoInicial; año <= añoFinal; año++)
                for (int mes = 1; mes <= 12; mes++)
                    Console.WriteLine($" año:{año}  mes :{mes}  ");

        }
    }
}
