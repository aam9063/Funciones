/*
 * Definir parámetros de salida
Utilizaremos la palabra reservada out (líneas 6 y 7) antes del tipo para indicar un parámetro de salida.

Equivale al paso por referencia, pero solo de salida, es decir los parámetros reales no tienen que estar inicializados.

Su uso muy aclaratorio para el programador, cuando un método tiene más de un parámetro de salida, además la devolución por referencia es menos costosa.

En la llamada (línea 19) deberemos anteponer al parámetro real la cláusula out. Además, out nos permite declarar el tipo del parámetro en la misma llamada.

Nota: La sintaxis del lenguaje a mejorado con el tiempo, y actualmente disponemos de otros mecanismos para devolver más de un parámetro, como son las Tuplas de las que hablaremos más adelante en el tema y los Objetos Anónimos que veremos más adelante en el curso.
 */

class Ejemplo
{
    // Es conveniente colocarlos al final del interfaz.
    public static void Direccion(
        double anguloGr,
        out double sen,
        out double cos)
    {
        double anguloRad = anguloGr * Math.PI / 180;
        // Como están marcados de salida si se quedan sin asignar
        // el compilador me dará un error.
        sen = Math.Sin(anguloRad);
        cos = Math.Cos(anguloRad);
    }
    static void Main()
    {
        double anguloGr = 75;
        // Se pueden declarar en la misma llamada a la función.
        Direccion(anguloGr, out double sen, out double cos);
        Console.WriteLine($"Sen = {sen:F3}");
        Console.WriteLine($"Cos = {cos:F3}");
    }
}
