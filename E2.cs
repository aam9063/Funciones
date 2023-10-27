/*
 Sakamoto:  calcula el dia de la semana

El precursor tabular para el algoritmo de Tøndering se materializa en la siguiente K & R C función.17​ Con cambios menores, fue adaptado para otros lenguajes de programación de alto nivel como APL2.18​ Publicado por Tomohiko Sakamoto en el grupo de noticias de Usenet comp.lang.c en 1992, es exacto para cualquier fecha gregoriana.19​20​

dayofweek(y, m, d)    /* 1 <= m <= 12,  y > 1752 (in the U.K.) 
{
    static int t[] = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
    if (m < 3)
    {
        y -= 1;
    }
    return (y + y / 4 - y / 100 + y / 400 + t[m - 1] + d) % 7;
}
La función no siempre conserva y , y devuelve 0 = domingo, 1 = lunes, etc. Por el contrario, la siguiente expresión

dow(m, d, y) { y -= m < 3; return (y + y / 4 - y / 100 + y / 400 + "-bed=pen+mad."[m] + d) % 7; }
publicado simultáneamente por Sakamoto no es fácilmente adaptable a otros idiomas, e incluso puede fallar si se compila en una computadora que codifica caracteres utilizando valores distintos de estándar ASCII (por ejemplo, EBCDIC), o en compiladores C que hacen cumplir el cumplimiento de ANSI C (incluso en código que sigue siendo compatible con la especificación K&R C original , donde se supone que las declaraciones de tipo omitidas son números enteros). Solo para esta última consideración, la versión más detallada de Sakamoto podría considerarse no portátil, al igual que la de Keith y Craver.

4
5


*/

using System;

class GFG
{


    public static int day_of_the_week_Sakamoto(int y, int m, int d)
    // the Tomohiko Sakamoto Algorithm

    {

        // if month is less than 3 reduce
        // year by 1
        if (m < 3)
            y -= 1;

        return ((y + y / 4 - y / 100 + y / 400 +
(m switch { 1 => 0, 2 => 3, 3 => 2, 4 => 5, 5 => 0, 6 => 3, 7 => 5, 8 => 1, 9 => 4, 10 => 6, 11 => 2, 12 => 4 }) + d) % 7);
    }


    public static void Main()
    {
        int day = 1, month = 6, year = 2023;

        Console.WriteLine(day_of_the_week_Sakamoto(year, month, day));

        Console.WriteLine(day_of_the_week_Sakamoto(2024, 3, 1));
        Console.WriteLine(day_of_the_week_Sakamoto(2023, 10, 25));

    }
}
