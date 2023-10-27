/*
 * Definir parámetros de entrada
Paso por valor
Si no ponemos ningún modificador o cláusula al parámetro formal. El paso será por valor.

Por tanto, si es un tipo valor el objeto se duplica en memoria y si pasamos un tipo referencia, se duplicará la referencia al objeto.
 */

class Ejemplo
{
    static void RestaUno(int d)
    {
        // El parámetro formal con id. 'd' solo existe en este
        // ámbito y es una copia en el Heap del tipo valor dato
        // se pasó como parámetro real.

        --d;
        Console.Write(d); // Muestra 4 

    } // el parámetro de entrada 'd' deja de existir al finalizar el método. 

    static void Main()
    {
        int dato = 5;

        // Se pasa una copia de dato por que es un Tipo-valor.
        RestaUno(dato);
        // Después de la llamada dato sigue valiendo 5 
        // por que lo que se modifica es la copia.
        Console.Write(dato); // Muestra 5
    }
}

