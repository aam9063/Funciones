/*
 * Definir parámetros de entrada
 * ¿Qué sucede si pasamos por valor un Tipo-referencia en lugar de un Tipo-Valor?
En el siguiente ejemplo vamos a ver que pasa usando el tipo referencia básico cadena.
(Este tipo lo veremos en más profundidad más adelante.)
 */

class Ejemplo
{
    static void AñadeExclamación(string t)
    {
        // t es una copia de la referencia texto.
        t = t + "!!!!";
        // t referenciará ahora a una cadena nueva que será destruida
        // al finalizar este ámbito de ejecución.
    }

    static void Main()
    {
        // texto será una referencia a un objeto cadena.
        string texto = "Adios";

        // Al pasar por valor hacemos una copia de la referencia.
        AñadeExclamación(texto);
        Console.Write(texto); // Muestra "Adios" sin la !
    }
}
