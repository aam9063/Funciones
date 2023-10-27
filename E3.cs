/*
 Generación de varios mes mediante el uso del Procediento

1.ImprimirMes *

2.CalculoDiasMEs

3.Calculo del dia de Semana*

Calculo del dias mes con la funcion que calcula los dias del mes
 */

using System;


class Program
{

    static int CalculoDiasMes(int año, int mes)
    {

        int dias = 0;

        switch (mes)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                dias = 31;
                break;
            case 2:
                dias = año % 4 == 0 && año % 100 != 0
                        ||
                        año % 400 == 0 ? 29 : 28;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                dias = 30;
                break;

        }

        return dias;

    }


    static void ImprimirMes(int mes, int diasMes, int primerDiaMes)
    {

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
        int año = 2024;

        Console.WriteLine($"Año :{año}");
        ImprimirMes(2, CalculoDiasMes(2024, 2), 3);
        ImprimirMes(3, CalculoDiasMes(2024, 3), 4);
        ImprimirMes(4, CalculoDiasMes(año, 4), 0);

    }
}
