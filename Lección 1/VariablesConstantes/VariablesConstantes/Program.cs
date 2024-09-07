using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double area; //variable definida sin valor asignado
            int radio = 5; // Variable definida con valor asignado
            const double pi = 3.1416; //Constante definida

            area = pi * radio * radio;
            Console.WriteLine(area);
            Console.ReadKey();
        }

    }
}
