/*
 * Colecciones
        - Son agrupaciones de objetos relacionados que pueden añadirse según se requieran
        
        Colecciones de tipo Listas: (espacio de nombre System.Collection.Generic)
            - 
            ¿Cómo declarar una lista?
                1. Escribir la palabra clave var (se utiliza para que el compilador defina cual es el tipo de dato que accederá a la instancia)
                2. Da un nombre a la lista
                3. Escribe el tipo de dato
                4. Colocar los elementos separandolos por comas
            Las listas son objetos dinamicos por lo tanto se pueden añadir y eliminar elementos de la misma
        
        Colecciones de tipo ArrayList: (espacio de nombre System.Collection)
            - Se pueden añadir varios tipos de datos al arreglo
            ¿Cómo declarar un ArrayList?
                1. Escribir ArrayList 
                2. Designar un nombre a la colección
                3. Asignar un nuevo ArrayList con NEW
                4. Abrir y cerrar paréntesis

        Colecciones de tipo Diccionarios (espacio de nombre System.Collection.Generic)
            - Se pueden añadir elementos al diccionario de cualquier tipo de datos 
            - Se accede a los elementos a través de una clave

 
 */

using System.Collections;

namespace VProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            //COLECCIONES DE TIPO LISTA

            var order = new List<string> { "elemento 1", "elemento 2", "elemento 3", "elemento 4" };

            //Acceder a los elementos de la lista 
            //forma 1: a través de bucles iterativos
            Console.WriteLine("Impresion de lista actual: ");
            foreach (var item in order) //foreach: bucle iterativo que pasa por todos los elementos de la lista y los almacena en la variable especificada 
            {
                Console.Write("  "+item + ", ");
            }

                //forma 2: a través de indices
            //comenzar desde 0 para acceder al primer elemento        
            Console.WriteLine("\nElemento index 0: "+order[0]);

            //Añadir elementos de una lista
            order.Add("elemento 9999");
            order.Add("elemento 8888");
            order.Remove("elemento 1");

            Console.WriteLine("Impresion de lista nueva: ");
            foreach (var item in order) //foreach: bucle iterativo que pasa por todos los elementos de la lista y los almacena en la variable especificada 
            {
                Console.Write("  "+ item + ", ");
            }


            //COLECCIONES DE TIPO ARRAYLIST
            //Declaración de arraylist
            ArrayList arrayList = new ArrayList();

            //Declaración de diccionarios
            //Creación de instancia para un diccionario que reciba los elementos de la clase definida
            Dictionary<string, Elementos> elementos = new Dictionary<string, Elementos>
            {
                {"Fe", new Elementos("Fe", "Hierro", 26, true ) },
                {"Mg", new Elementos("Mg", "Magnesio", 12, true ) },
                {"Au", new Elementos("Au", "Oro", 79, true ) },
                {"N", new Elementos("N", "Nitrógeno", 7, false ) },
                {"P", new Elementos("P", "Fósforo", 15, false ) },

            };

            //Acceder a la informacion del diccionario
            //El objeto KeyValuePair divide los elementos del diccionario en llave y valor
            foreach (KeyValuePair<string, Elementos> keyValue in elementos)
            {
                Elementos elementos1 = keyValue.Value;
                Console.WriteLine("Clave: "+keyValue.Key);
                Console.WriteLine(" Valores: " + elementos1.Simbolo+ ", "+elementos1.Nombre + ", "+elementos1.NumeroAtomico + ", ¿es metalico?: " + elementos1.VerificarMetalico);
            }
            Console.ReadKey();

            

        }

    }

    //Creación de clase Elemento
    public class Elementos
    {
        public string Simbolo { get; set; }
        public string Nombre { get; set; }
        public int NumeroAtomico { get; set; }
        public bool VerificarMetalico { get; set; }
        public Elementos(string simbolo, string nombreElemento, int numeroAtomico, bool verificarMetalico) 
        {
            Simbolo = simbolo;
            Nombre = nombreElemento;
            NumeroAtomico = numeroAtomico;
            VerificarMetalico = verificarMetalico;
        }
    }

}

