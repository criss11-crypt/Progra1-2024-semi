using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {            //Uso de matrices.
            int[] numeros = new int[] { 2, 8, 9, 10, 1, 3 };
            Console.WriteLine("El numero de la posicion 3 es {0}", numeros[3]);
            //Pausa
            Console.ReadKey();
        }
    }
}

