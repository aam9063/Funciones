/*
 *  Definir parámetros de entrada/salida
Utilizaremos el modificador ref (línea 3) antes del tipo para indicar un paso por referencia.

Igual que in pero podremos modificar el valor del parámetro formal por eso consideramos que es un parámetro que 'entra' con un valor y 'sale' con otro.

Deberemos evitarlos en la medida de lo posible, pues dan lugar a efectos laterales y acoplamiento.

En la llamada (línea 20) deberemos anteponer al parámetro real la cláusula ref.
 */

class Ejemplo
{
    static void RestaUno(ref int d)
    {
        // El parámetro formal con id. 'd' es una referencia
        // a dato que se pasó como parámetro real.

        --d; // Ahora podemos modificar sin problema el valor del parámetro.
        Console.Write(d); // Muestra 4

    } // el parámetro de entrada 'd' deja de existir y por tanto la referencia a dato.
      // pero dato sigue existiendo.

    static void Main()
    {
        int dato = 5;

        // Se pasa una referencia a la zona de memoria donde está dato.
        // El valor podrá modificarse internamente.
        RestaUno(ref dato);
        Console.Write(dato); // Muestra 4
    }
}
