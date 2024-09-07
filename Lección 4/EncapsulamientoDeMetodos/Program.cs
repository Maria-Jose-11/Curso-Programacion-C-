/*
 * Encapsulamiento de métodos con Delegar
        - Un delegado es un tipo de referencia que encapsula un método para que sea utilizado como parámetro en otros métodos, 
          con la finalidad de invocar al método desde la instancia del delegado.
        
        ¿Cómo definir un delegado?
            1. Escribir el modificador de acceso
            2. Asignar la palabra clave "delegate"
            3. Indicar el valor de retorno del método (void, string, int, etc)
            4. Asignarle un nombre
            5. Asignar los parámetros de entrada con su tipo y nombre en caso de requerirlos

        Propiedades de un delegado: 
            - (Multidifusión) Puede encapsular varios métodos y ejecutarlos por orden de asignación.
 
 
 */

namespace VProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

    }
}