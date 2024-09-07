namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Resumen de tema: Polimorfismo
                Definir diferentes comportamientos para una misma accíón
                El polimorfismo en C# se define en clases como un miembro virtual que se puede modificar sin restricción en clases derivadas
                
            */

            //Creación de objetos
            Forma forma = new Forma();
            Circulo circulo = new Circulo();
            Rectangulo rectangulo = new Rectangulo();

            forma.Dibujo();
            circulo.Dibujo();
            rectangulo.Dibujo();

            Console.ReadKey();

        }
    }

    public class Forma
    {
        //Definición de un miembro virtual
        public virtual void Dibujo()
        {
            Console.WriteLine("Alguna forma: ");
        }

        //Clase derivada que puede modificar el miembro virtual definido anteriormente
        
    }

    public class Circulo : Forma
    {
        public override void Dibujo()
        {
            Console.WriteLine(" Forma Circular");
            //Invalida el metodo heredado
            //base.Dibujo();
        }
    }

    public class Rectangulo : Forma
    {
        public override void Dibujo()
        {
            Console.WriteLine(" Forma rectangular");
            //Invalida el metodo heredado
            //base.Dibujo();
        }
    }





}