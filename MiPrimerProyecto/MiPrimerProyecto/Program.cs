using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
            //conversores.
        {
            while (true)
            {
                Console.WriteLine("Seleccione un conversor:");
                Console.WriteLine("1. Monedas");
                Console.WriteLine("2. Masa");
                Console.WriteLine("3. Volumen");
                Console.WriteLine("4. Longitud");
                Console.WriteLine("5. Almacenamiento");
                Console.WriteLine("6. Tiempo");
                Console.WriteLine("7. Salir");

                int opc = int.Parse(Console.ReadLine());

                if (opc == 7) break;

                Console.WriteLine("Ingrese valor:");
                double valor = double.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: ConvertirMonedas(valor); break;
                    case 2: ConvertirMasa(valor); break;
                    case 3: ConvertirVolumen(valor); break;
                    case 4: ConvertirLongitud(valor); break;
                    case 5: ConvertirAlmacenamiento(valor); break;
                    case 6: ConvertirTiempo(valor); break;
                    default: Console.WriteLine("Opción inválida."); break;
                }
            }
        }

        static void ConvertirMonedas(double valor)
        {
            Console.WriteLine("1. USD a EUR");
            Console.WriteLine("2. EUR a USD");
            Console.WriteLine("3. QUETZAL a COLON SALVADOREÑO");
            Console.WriteLine("4. CORDOVA a LIBRA ESTERLINA");
            Console.WriteLine("5. QUETZAL a PESO MX");
            Console.WriteLine("6. YUAN a LEMPIRA");
            Console.WriteLine("7. COLON SALVADOREÑO a QUETZAL");
            Console.WriteLine("8. RUPIAS a PESO MX");
            Console.WriteLine("9. QUETZAL a RUPIAS");
            Console.WriteLine("10. YUAN a USD");
            int opc = int.Parse(Console.ReadLine());
            double resultado = 0;
            switch (opc)
            {
                case 1: resultado = valor * 0.91; break;
                case 2: resultado = valor * 1.10; break;
                case 3: resultado = valor * 1.13; break;
                case 4: resultado = valor * 0.21; break;
                case 5: resultado = valor * 2.41; break;
                case 6: resultado = valor * 3.46; break;
                case 7: resultado = valor * 0.89; break;
                case 8: resultado = valor * 0.22; break;
                case 9: resultado = valor * 10.83; break;
                case 10: resultado = valor * 0.14; break;
                default: Console.WriteLine("Opción inválida."); break;
            }
            Console.WriteLine("Resultado: " + resultado);
        }

        static void ConvertirMasa(double valor)
        {
            Console.WriteLine("1. Kilogramo a Libra");
            Console.WriteLine("2. Libra a Kilogramo");
            Console.WriteLine("3. kilogramo a onza");
            Console.WriteLine("4. tonelada a kilogramo");
            Console.WriteLine("5. gramo a onza");
            Console.WriteLine("6. gramo a miligramo");
            Console.WriteLine("7. onza a libra");
            Console.WriteLine("8. kilogramo a tonelada");
            Console.WriteLine("9. onza a gramo");
            Console.WriteLine("10. miligramo a onza");
            int opc = int.Parse(Console.ReadLine());
            double resultado = 0;
            switch (opc)
            {
                case 1: resultado = valor * 2.20462; break;
                case 2: resultado = valor * 0.453592; break;
                case 3: resultado = valor * 35.274; break;
                case 4: resultado = valor * 1000; break;
                case 5: resultado = valor * 35.274; break;
                case 6: resultado = valor * 100; break;
                case 7: resultado = valor / 16; break;
                case 8: resultado = valor / 1000; break;
                case 9: resultado = valor * 28.35; break;
                case 10: resultado = valor / 28350; break;
                default: Console.WriteLine("Opción inválida."); break;
            }
            Console.WriteLine("Resultado: " + resultado);
        }

        static void ConvertirVolumen(double valor)
        {
            Console.WriteLine("1. Litro a Galon");
            Console.WriteLine("2. Galon a Litro");
            Console.WriteLine("3. taza a litro");
            Console.WriteLine("4. cuarto a litro");
            Console.WriteLine("5. mililitro a onza");
            Console.WriteLine("6. mililitro a litro");
            Console.WriteLine("7. galon a mililitro");
            Console.WriteLine("8. galon a taza");
            Console.WriteLine("9. cuarto a galon");
            Console.WriteLine("10. litro a taza");
            
            int opc = int.Parse(Console.ReadLine());
            double resultado = 0;
            switch (opc)
            {
                case 1: resultado = valor * 0.264172; break;
                case 2: resultado = valor * 3.78541; break;
                case 3: resultado = valor / 4.167; break;
                case 4: resultado = valor * 1.137; break;
                case 5: resultado = valor / 28.413; break;
                case 6: resultado = valor / 28.413; break;
                case 7: resultado = valor * 3785; break;
                case 8: resultado = valor * 15.773; break;
                case 9: resultado = valor / 4; break;
                case 10: resultado = valor * 4.167; break;
                
                default: Console.WriteLine("Opción inválida."); break;
            }
            Console.WriteLine("Resultado: " + resultado);
        }

        static void ConvertirLongitud(double valor)
        {
            Console.WriteLine("1. metros a pies");
            Console.WriteLine("2. pies a metros");
            Console.WriteLine("3. milimetro a metro");
            Console.WriteLine("4. centimetro a Metro");
            Console.WriteLine("5. metro a kilometro");
            Console.WriteLine("6. kilometro a milla");
            Console.WriteLine("7. pulgada a pie");
            Console.WriteLine("8. milla a yarda");
            Console.WriteLine("9. yarda a centimetro");
            Console.WriteLine("10. pie a pulgada");

            int opc = int.Parse(Console.ReadLine());
            double resultado = 0;
            switch (opc)
            {
                case 1: resultado = valor * 3.28084; break;
                case 2: resultado = valor * 0.3048; break;
                case 3: resultado = valor / 1000; break;
                case 4: resultado = valor / 1000; break;
                case 5: resultado = valor / 1000; break;
                case 6: resultado = valor / 1.609; break;
                case 7: resultado = valor / 12; break;
                case 8: resultado = valor * 5280; break;
                case 9: resultado = valor * 91.44; break;
                case 10: resultado = valor / 12; break;
                default: Console.WriteLine("Opción inválida."); break;
            }
            Console.WriteLine("Resultado: " + resultado);
        }

        static void ConvertirAlmacenamiento(double valor)
        {
            Console.WriteLine("1. bit a kilobyte");
            Console.WriteLine("2. kilobit a bit");
            Console.WriteLine("3. byte a bit");
            Console.WriteLine("4. kilobyte a megabyte");
            Console.WriteLine("5. megabyte a gigabyte");
            Console.WriteLine("6. gigabyte a terabyte");
            Console.WriteLine("7. petabyte a gigabyte");
            Console.WriteLine("8. byte a kilobyte");
            Console.WriteLine("9. terabyte a gigabyte");
            Console.WriteLine("10. bit a kilobyte");
            int opc = int.Parse(Console.ReadLine());
            double resultado = 0;
            switch (opc)
            {
                case 1: resultado = valor / 8000; break;
                case 2: resultado = valor * 1000; break;
                case 3: resultado = valor * 8; break;
                case 4: resultado = valor / 1000; break;
                case 5: resultado = valor / 1000; break;
                case 6: resultado = valor / 1000; break;
                case 7: resultado = valor * 1e+6; break;
                case 8: resultado = valor / 1000; break;
                case 9: resultado = valor * 1000; break;
                case 10: resultado = valor / 800; break;
                default: Console.WriteLine("Opción inválida."); break;
            }
            Console.WriteLine("Resultado: " + resultado);
        }

        static void ConvertirTiempo(double valor)
        {
            Console.WriteLine("1. Minutos a Segundos");
            Console.WriteLine("2. Segundos a Minutos");
            Console.WriteLine("3. minuto a hora");
            Console.WriteLine("4. hora a minuto");
            Console.WriteLine("5. hora a dia");
            Console.WriteLine("6. dia a semana");
            Console.WriteLine("7. semana a mes");
            Console.WriteLine("8. mes a año");
            Console.WriteLine("9. año a decada");
            Console.WriteLine("10. decada a siglo");
            int opc = int.Parse(Console.ReadLine());
            double resultado = 0;
            switch (opc)
            {
                case 1: resultado = valor * 60; break;
                case 2: resultado = valor / 60; break;
                case 3: resultado = valor / 60; break;
                case 4: resultado = valor * 60; break;
                case 5: resultado = valor * 24; break;
                case 6: resultado = valor / 7; break;
                case 7: resultado = valor / 4; break;
                case 8: resultado = valor / 12; break;
                case 9: resultado = valor / 10; break;
                case 10: resultado = valor / 10; break;
                default: Console.WriteLine("Opción inválida."); break;
            }
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
           



        












