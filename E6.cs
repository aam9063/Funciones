/* Llamada a método estático con retorno
 Si se hace dentro de la clase donde se define:
tipoDevuelto idVariable = IdentificadorMétodo(parámetrosReales);
(Son los que usaremos para aprender a modularizar en los primeros programas)
*/

class Principal
{
    static bool AñoBisiesto(ushort año)
    {
        return (bool)(año % 4 == 0 && (año % 100 != 0 || año % 400 == 0));
    }

    static void Main()
    {
        string salida = (AñoBisiesto(2025) ? "Es" : "No es") + " bisiesto";
        Console.WriteLine(salida);
    }
}
