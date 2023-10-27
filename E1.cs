/*
 * Función :

Calculo de los dias que tiene un mes, para un mes y un año dado

Año :2024  Mes: 3  Dias del Mes :31
Año :2024  Mes:2 Dias del Mes :29
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


    static void Main()
    {
        int año = 2024;
        int diasMes;
        int mes;

        mes = 3;

        Console.WriteLine($"Año :{año}");
        diasMes = CalculoDiasMes(año, mes);
        Console.WriteLine($"Año :{año}  Mes: {mes}  Dias del Mes :{diasMes})");
        diasMes = CalculoDiasMes(2025, 3);
        Console.WriteLine($"Año :{2025}  Mes: {3}  Dias del Mes :{diasMes})");



        // Llamada directa a la funcion
        Console.WriteLine($"Año :2024  Mes:2 Dias del Mes :{CalculoDiasMes(2024, 2)}");


    }
}
