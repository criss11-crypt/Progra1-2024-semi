using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ProgramaImpuesto
{
    class ProgramaImpuestoYConversor
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Calcular Impuesto a las Actividades Económicas");
                Console.WriteLine("2. Convertir Unidades de Superficie");
                Console.WriteLine("3. Salir");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 3)
                    break;

                switch (opcion)
                {
                    case 1:
                        CalcularImpuesto();
                        break;
                    case 2:
                        ConvertirUnidades();
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        static void CalcularImpuesto()
        {
            // Solicitar al usuario el monto de la actividad económica
            Console.Write("Ingrese el monto de la actividad económica: ");
            double monto = Convert.ToDouble(Console.ReadLine());

            // Calcular el impuesto
            double impuesto = CalcularImpuestoLogica(monto);

            // Mostrar el resultado
            Console.WriteLine($"El impuesto a las actividades económicas para un monto de {monto} es: {impuesto}");
        }

        static double CalcularImpuestoLogica(double monto)
        {
            double precio = 0, adicional = 0, rango_desde = 0;

            if (monto >= 0.01 && monto <= 500)
            {
                precio = 1.5;
                adicional = 0;
                rango_desde = 0.01;
            }
            else if (monto > 500 && monto <= 1000)
            {
                precio = 1.5;
                adicional = 3;
                rango_desde = 500.01;
            }
            else if (monto > 1000 && monto <= 2000)
            {
                precio = 3;
                adicional = 3;
                rango_desde = 1000.01;
            }
            else if (monto > 2000 && monto <= 3000)
            {
                precio = 6;
                adicional = 3;
                rango_desde = 2000.01;
            }
            else if (monto > 3000 && monto <= 6000)
            {
                precio = 9;
                adicional = 2;
                rango_desde = 3000.01;
            }
            else if (monto > 6000 && monto <= 18000)
            {
                precio = 15;
                adicional = 2;
                rango_desde = 6000.01;
            }
            else if (monto > 18000 && monto <= 30000)
            {
                precio = 39;
                adicional = 2;
                rango_desde = 18000.01;
            }
            else if (monto > 30000 && monto <= 60000)
            {
                precio = 63;
                adicional = 1;
                rango_desde = 30000.01;
            }
            else if (monto > 60000 && monto <= 100000)
            {
                precio = 93;
                adicional = 0.8;
                rango_desde = 60000.01;
            }
            else if (monto > 100000 && monto <= 200000)
            {
                precio = 125;
                adicional = 0.7;
                rango_desde = 100000.01;
            }
            else if (monto > 200000 && monto <= 300000)
            {
                precio = 195;
                adicional = 0.6;
                rango_desde = 200000.01;
            }
            else if (monto > 300000 && monto <= 400000)
            {
                precio = 255;
                adicional = 0.45;
                rango_desde = 300000.01;
            }
            else if (monto > 400000 && monto <= 500000)
            {
                precio = 300;
                adicional = 0.4;
                rango_desde = 400000.01;
            }
            else if (monto > 500000 && monto <= 1000000)
            {
                precio = 340;
                adicional = 0.3;
                rango_desde = 500000.01;
            }
            else if (monto > 1000000 && monto <= 99999999)
            {
                precio = 490;
                adicional = 0.18;
                rango_desde = 1000000.01;
            }

            // Calcular el impuesto utilizando la fórmula
            double diferencia = monto - rango_desde;
            double impuesto = diferencia / 1000 * adicional + precio;

            return Math.Round(impuesto, 2);
        }

        static void ConvertirUnidades()
        {
            Console.WriteLine("Seleccione la conversión deseada:");
            Console.WriteLine("1. PIE CUADRADO a VARA CUADRADA");
            Console.WriteLine("2. VARA CUADRADA a PIE CUADRADO");
            Console.WriteLine("3. YARDA CUADRADA a PIE CUADRADO");
            Console.WriteLine("4. METRO CUADRADO a YARDA CUADRADA");
            Console.WriteLine("5. TAREA a MANZANA");
            Console.WriteLine("6. MANZANA a HECTÁREAS");

            int opc = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor a convertir:");
            double valor = double.Parse(Console.ReadLine());

            double resultado = 0;

            switch (opc)
            {
                case 1: resultado = valor * 0.7; break; 
                case 2: resultado = valor * 1.43; break; 
                case 3: resultado = valor * 9; break; 
                case 4: resultado = valor * 1.2; break; 
                case 5: resultado = valor * 0.155; break; 
                case 6: resultado = valor * 1.5; break; 
                default:
                    Console.WriteLine("Opción inválida.");
                    return;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}




















