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
        {//estructuras de control.
            //1. if. ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            //2. Switch ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            string continuar = "s";
            while (continuar == "s")
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad < 0)
                {
                    Console.WriteLine("Edad incorrecta.");
                }
                else if (edad <= 2)
                {
                    Console.WriteLine("Eres un bebe");
                }
                else if (edad < 12)
                {
                    Console.WriteLine("Eres un niño");
                }
                else if (edad < 18)
                {
                    Console.WriteLine("Eres un adolescente.");
                }
                else if (edad <= 65)
                {
                    Console.WriteLine("Bienvenido al mundo de las reposabilidades.");
                }
                else if (edad <= 80)
                {
                    Console.WriteLine("Eres un adulto mayor");
                }
                else
                {
                    Console.WriteLine("Larga vida");
                    Console.WriteLine("*** MENU ***");
                    Console.WriteLine("1. Promedio Notas");
                    Console.WriteLine("2. Promedio Serie Numeros");
                    Console.WriteLine("3. Clasificacion edad");
                    Console.WriteLine("4. Salir");
                    Console.Write("Opcion: ");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1://if(opcion==1)
                            promedio();
                            break;
                        case 2: //if(opcion==2)
                            promedioSerie();
                            break;
                        case 3://if(opcion==3)
                            clasificacionEdad();
                            break;
                        case 4://if(opcion==4)
                            continuar = "n";
                            break;
                        default://else
                            Console.WriteLine("opcion incorrecta \n\n");
                            break;
                    }
                    Console.Write("Desea continuar presione s, sino cualquier tecla.");
                    continuar = Console.ReadLine();
                }
            }
            static void promedio()
            {
                Console.Write("Lab1: ");
                double lab1 = double.Parse(Console.ReadLine());

                Console.Write("Lab2: ");
                double lab2 = double.Parse(Console.ReadLine());

                Console.Write("Parcial 1: ");
                double parcial1 = double.Parse(Console.ReadLine());

                double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
                Console.WriteLine("La nota de C1 es: {0}", c1);

                Console.Write("Lab1: ");
                lab1 = double.Parse(Console.ReadLine()); //8

                Console.Write("Lab2: ");
                lab2 = double.Parse(Console.ReadLine()); //9

                Console.Write("Parcial 1: ");
                parcial1 = double.Parse(Console.ReadLine()); //7

                double c2 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
                Console.WriteLine("La nota de C2 es: {0}", c2);
            }
            static void promedioSerie()
            {
                int[] serie = new int[] { 5, 4, 6, 8, 9 }; //32
                int suma = 0;
                foreach (int num in serie)
                {
                    suma += num;
                }
                decimal prom = suma / serie.Length;
                Console.WriteLine("La suma es: {0}, el promedio {1}", suma, prom);
            }
            static void clasificacionEdad()
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad < 0)
                {
                    Console.WriteLine("Edad incorrecta.");
                }
                else if (edad <= 2)
                {
                    Console.WriteLine("Eres un bebe");
                }
                else if (edad < 12)
                {
                    Console.WriteLine("Eres un niño");
                }
                else if (edad < 18)
                {
                    Console.WriteLine("Eres un adolescente.");
                }
                else if (edad <= 65)
                {
                    Console.WriteLine("Bienvenido al mundo de las reposabilidades.");
                }
                else if (edad <= 80)
                {
                    Console.WriteLine("Eres un adulto mayor");
                }
                else
                {
                    Console.WriteLine("Larga vida");
                }
            }
        }
    }
}
 



