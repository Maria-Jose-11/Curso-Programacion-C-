using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Constantes
{
    class Variables_Constantes
    {
        static void Main1(string[] args)
        {
            double area; //variable sin valor asignado
            int radio = 5; // Variable con valor asignado
            const double pi = 3.1416;

            area = pi * radio * radio;
            Console.WriteLine(area);
            Console.ReadKey();
        }
        
    }
}
