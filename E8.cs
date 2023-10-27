/*
 * Generacion de Calendario por Años

Unimos todo el codigo visto para generar años completos
 */

using System;

class Program
{
    public static int day_of_the_week_Sakamoto(int y, int m, int d)
    // the Tomohiko Sakamoto Algorithm

    {
        // if month is less than 3 reduce
        // year by 1
        if (m < 3)
            y -= 1;

        return ((y + y / 4 - y / 100 + y / 400 + (m switch { 1 => 0, 2 => 3, 3 => 2, 4 => 5, 5 => 0, 6 => 3, 7 => 5, 8 => 1, 9 => 4, 10 => 6, 11 => 2, 12 => 4 }) + d) % 7);
    }

    static int CalculoDiasMes(int año, int mes)
    {
        int dias = mes switch
        {
            < 2 => año % 4 == 0 && año % 100 != 0  // Si es febrero calculo los días
                 ||                              // viendo si el año es bisiesto.
                 año % 400 == 0 ? 29 : 28,
            4 or 6 or 9 or 11 => 30,             // Si es uno de los meses que tiene 30
                                                 // evalúo el switch a 30.
            _ => 31                              // EN cualquier otro caso tendrá 31.        
        };

        return dias;
    }


    static void ImprimirMes(int año, int mes)
    {

        int primerDiaMes = day_of_the_week_Sakamoto(año, mes, 1);
        int diasMes = CalculoDiasMes(año, mes);

        Console.WriteLine($"Año :{año}");
        Console.WriteLine($"Mes :{mes}");
        Console.WriteLine("Lun  Mar  Mié  Jue  Vie  Sáb Dom");

        for (int i = 0; i < primerDiaMes; i++)
        {
            Console.Write("     ");
        }

        for (int dia = 1; dia <= diasMes; dia++)
        {
            Console.Write($"{dia,2}   ");

            if (((dia + primerDiaMes) % 7 == 0))
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine();
    }



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
                    ImprimirMes(año, mes);

        }
    }

}
