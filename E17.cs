/*
 * Determinar parámetros de salida
 * A partir de C#7 podemos hacer la siguiente sintaxis mucho más recomendable usando tuplas.
static (double sen, double cos) Direccion(double anguloGr) {...}
 */

class Ejemplo
{
    static (double sen, double cos) Direccion(double anguloGr)
    {
        double anguloRad = anguloGr * Math.PI / 180;
        return (Math.Sin(anguloRad), Math.Cos(anguloRad));
    }
    static void Main()
    {
        double anguloGr = 75;
        double sen, cos;

        (sen, cos) = Direccion(anguloGr);


        Console.WriteLine($"Sen = {sen:F3}");
        Console.WriteLine($"Cos = {cos:F3}");
    }
}
