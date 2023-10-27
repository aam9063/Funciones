/*
 * Paso por referencia con in
Al poner el modificador o cláusula in (línea 3) al identificador del parámetro formal. El paso será por referencia, pero no lo podremos modificar dentro del método.

Por tanto, si es un tipo valor será una referencia al mismo objeto en memoria y si pasamos un tipo referencia, se tratará de una referencia a la referencia.

En la llamada (línea 20) deberemos anteponer al parámetro real la cláusula in.
 */

class Ejemplo
{
    static void RestaUno(in int d)
    {
        // El parámetro formal con id. 'd' es una referencia
        // a dato que se pasó como parámetro real.

        // Ya no podremos hacer --d; pues dará error.
        Console.Write(d); // Muestra 5

    } // el parámetro de entrada 'd' deja de existir y por tanto la referencia a dato.
      // pero dato sigue existiendo.

    static void Main()
    {
        int dato = 5;

        // Se pasa una referencia a la zona de memoria donde está dato.
        // Sabemos que nunca se modificará el valor internamente.
        RestaUno(in dato);
        Console.Write(dato); // Muestra 5
    }
}
