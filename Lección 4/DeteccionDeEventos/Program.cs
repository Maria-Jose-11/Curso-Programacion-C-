/*
 * Detección de eventos
        
        - Eventos: Se implementan cuando algo relevante ocurre durante la ejecución del programa
                   Habilitan la clase u objeto llamado "Publicador" para notificarlos a otras clases u objetos que reciben por nombre "Suscriptores"
        
                Conceptos claves: 
                    - Evento: Declaración del delegado
                    - Publicador: Metodo que utiliza el delegado en sus parámetros
                    - Manejador: Metodo que se encapsula en el delegado
                    - Suscripción: Propiedad de multidifusión de los delegados

                Sintaxis para definir eventos:
                    1. Definir el tipo de modificador de acceso
                    2. Escribir la palabra clave "event"
                    3. Escribir EventHandler<EventArgs>
                    4. Escribir el nombre del evento

                Sintaxis para definir Manejador
                    1. Escribir el tipo de modificador de acceso
                    2. Escribir el valor de retorno (tipo void, string, int, etc...)
                    3. Escribir el nombre del método manejador y abrir paréntesis
                    4. Definir el primer parámetro como un objeto de tipo "object"
                    5. Definir el segundo parámetro como un objeto de una clase derivada de "EventArgs"

        (Importante: Si los objetos no estan suscritos al evento, este no se activará).



 
 */

using System.Runtime.CompilerServices;

namespace VProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO: Programa que permita crear un evento de alerta que muestre un mensaje cuando se actualice el area del circulo 

            //Ejemplo p6. Creación de los objetos Circulos con sus respectivos parámetros de entrada
            Circulo c1 = new Circulo(25);
            Circulo c2 = new Circulo(32);
            //Ejemplo p7.Suscribir los objetos al evento creado
            c1.CirculoCambio += ManejadorCirculoCambio;
            c2.CirculoCambio += ManejadorCirculoCambio;
            //Ejemplo p8: Utilizar el método para dibujar los círculos en pantalla
            c1.Dibujar();
            c2.Dibujar();
            //Ejemplo p9: Actualizar el área de los círculos y volver a dibujar los círculos
            c1.Actualizar(59);
            c2.Actualizar(98);

            Console.ReadKey();
        }

        //Ejemplo p3. Declarar el método manejador del evento
        private static void ManejadorCirculoCambio(object sender, CirculoEventArgs AreaCambio)
        {
            Circulo s = (Circulo)sender;
            Console.WriteLine("Nuevo evento: el área del circulo ahora es {0}", AreaCambio.NuevaArea );
            s.Dibujar();
        }
    }

    //Clase Circulo para calcular el area del circulo y actualizarla

    public class Circulo
    {
        private double radio;
        public double Area { get; set; }
        public Circulo(double rad)
        {
            radio = rad;
            Area = 3.14 * radio *radio;
            //Eejmplo p5. LLamar al método publicador desde el método Actualizar de la clase circulo
            
        }
        public void Actualizar(double rad)
        {
            radio = rad;
            Area = 3.14 * radio * radio;
            OnCirculoCambio(new CirculoEventArgs(Area));
        }

        public void Dibujar()
        {
            
            Console.WriteLine("Dibujando un círculo");
        }

        //Ejemplo p2. Declaración del evento dentro de la clase circulo
        public event EventHandler<CirculoEventArgs> CirculoCambio;

        //Ejemplo p4. Declaración del método publicador en la clase circulo
        protected void OnCirculoCambio(CirculoEventArgs AreaCambio)
        {
            EventHandler<CirculoEventArgs> Manejador = CirculoCambio;
            if(Manejador != null)
            {
                Manejador(this, AreaCambio);
            }
        }
    }

    //Ejemplo p1. Creación de la clase que hereda de EventArgs
    public class CirculoEventArgs : EventArgs
    {
        public double NuevaArea { get; set; }
        public CirculoEventArgs(double nuevaArea)
        {
            NuevaArea = nuevaArea;
        }
    }

}