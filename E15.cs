/*
 * ¿Qué sucede si pasamos por referencia un Tipo-referencia en lugar de un Tipo-Valor?
Veamos que pasa con el ejemplo que usamos en el paso por valor.
 */

class Ejemplo
{
    static void AñadeExclamación(ref string t)
    {
        // t es una referencia a la referencia texto.
        t = t + "!!!!";
        // al cambiar ahora t estaremos cambiando el valor de la referencia texto.
    }

    static void Main()
    {
        // texto será una referencia a un objeto cadena.
        string texto = "Adios";

        // Al pasar por valor hacemos pasaremos una referencia a la referencia.
        AñadeExclamación(ref texto);
        Console.Write(texto); // Muestra "Adios!"
    }
}
