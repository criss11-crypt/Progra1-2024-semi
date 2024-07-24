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
        {//Prioridad de los operadores arigmeticos.
            //ejercicios obtener el promedio de una serie de numeros
            int[] serie = new int[] { 5,4,6,8,9};//32
            int suma = 0;
            foreach (int num in serie) {
                suma = suma + num;
            }
            double prom = suma / serie.Length;
            Console.WriteLine("la suma es: {0}, el promedio {1}", suma, prom);
            //pausa.
            Console.ReadLine();
                



        }
     
    }
}
