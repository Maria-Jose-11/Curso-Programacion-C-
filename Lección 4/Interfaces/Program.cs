/*
 * Interfaces
        Elemento de programación no implementable solo definible
   Consideraciones a tomar en cuenta para declarar interfaces:
        - (El nombre de la interfaz debe comenzar por la letra capital I)
        - Las interfaces no llevan modificadores de acceso (por defecto son de tipo publicas)
        - Para que funcionen el uso de interfaces, se deben implementar todos los miembros de está en la clase
    ¿Como heredar de varias interfaces?
        Al crear la clase, se debe agregar una coma luego de añadir la primera interfaz:
            Ejm: class Tanque: IVehiculo, ArmaDeGuerra
        (Importante: No olvidar que se deben implementar todos los metodos de las interfaces)
    ¿Cuándo utilizar interfaces?
        Cuando existan varias clases en el código que hagan lo mismo con la finalidad de crear plantillas que puedan ser utilizadas por múltiples clases 
 * 
 */


namespace VProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto de clase Tanque
            Tanque tanque = new Tanque();

            //Llamar a los métodos que reciben al objeto interfaz
            ValidarVehiculo(tanque);
            ValidarArmaDeGuerra(tanque);

            int aceleracion = 80;
            int angulos = 130;

            //Llamar a los métodos propios de la interfaz
            tanque.Acelerar(aceleracion);
            tanque.Frenar();
            tanque.Girar(angulos);
            tanque.Apuntar();
            tanque.Disparar();
            
            
        }

        //1. Creación de métodos dentro de la clase program

        //Primer método que reciba un objeto derivado de la interfaz IVehiculo
        static void ValidarVehiculo(IVehiculo a)
        {
            Console.WriteLine("Vehiculo");
        }

        //Segundo método que reciba un objeto derivado de la interfaz IArmaDeGuerra
        static void ValidarArmaDeGuerra(IArmaDeGuerra a)
        {
            Console.WriteLine("Arma de guerra");
        }
    }


    //Clase tanque que hereda de varias interfaces
    class Tanque : IVehiculo, IArmaDeGuerra
    {
        //Importante: implementar todos los métodos de las interfaces heredadas
        public void Acelerar(int kmh)
        {
            Console.WriteLine($"  Tanque acelerado a {kmh}");
        }
        public void Frenar()
        {
            Console.WriteLine("  Tanque frenado");
        }
        public void Girar(int angulos)
        {
            Console.WriteLine($"  Tanque girando a {angulos} grados");
        }
        public void Apuntar()
        {
            Console.WriteLine("  Tanque apuntando");
        }
        public void Disparar()
        {
            Console.WriteLine("  Tanque disparando");
        }
    }

    //Creación de interfaces
    //Interface Vehículo
    interface IVehiculo
    {
        void Acelerar(int kmh);
        void Frenar();
        void Girar(int angulos);
    }

    //Interface Arma De Guerra 
    interface IArmaDeGuerra
    {
        void Apuntar();
        void Disparar();
    }

}

