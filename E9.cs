/*
 * Declaración de método estático sin retorno
Usaremos para ello el tipo void (vacío) como tipo de retorno.

Su sintaxis suponiendo que es un método estático dentro de una misma clase será:

static void IdProcedimiento(parámetros_formales) 
{
    // Cuerpo del método
    return; // Podemos obviarlo
}
*/

class Datos
{
    public static void Muestra(
        string nombre,
        string apellido,
        ushort edad)
    {
        Console.WriteLine($"   Nombre: {nombre}\n" +
                          $" Apellido: {apellido}\n" +
                          $"     Edad: {edad}");
    }

    public static void MétodoSinRetorno()
    {
        // Llamada desde un método de la misma clase.
        Muestra("Xusa", "García", 15);
    }
}

class Principal
{
    static void Main()
    {
        Datos.Muestra("Juanjo", "Guarinos", 18);
        Datos.MétodoSinRetorno();

        Datos.Muestra("Pepe", "Garcia", 81);
    }
}
