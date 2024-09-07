//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace HerenciaDeClases
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Resumen de tema: Herencia de Clases
                La herencia de clases es una de las caracteristicas principales en la Programación Orientada a objetos (POO)
                Permite crear clases nuevas que reutilizan campos, propiedades y métodos a partir de una clase Base.
                    - Clase base: Clase principal cuyos miembros se heredan.
                    - Clase derivada: Clase que hereda los miembros de la clase base
                                      Esta clase solo puede heredar una vez por lo que no puede tener dos clases base, pero si puede heredar de otra clase derivada (a esto se le llama Transitividad)
                                      Ejm de transitividad: Una clase A es la base de la clase B y a su vez la clase B es clase base de la clase C; es decir que la clase C hereda todos los miembros de la clase A y B.
            */
            
            //Creación de objeto de tipo Golden 
            Golden golden = new Golden();
            //La clase Golden heredó todos los métodos de la clase Perro por lo que puede utilizarlos en cualquier parte del código
            Console.WriteLine(golden.PerroLadrar());
            Console.ReadKey();

        }
    }

    //Declaración de clase base:
    public class Perro
    {
        public string PerroLadrar()
        {
            return "Perro ladrando";
        }
    }

    //Declaración de clase derivada:
    public class Golden : Perro
    {

    }

}

