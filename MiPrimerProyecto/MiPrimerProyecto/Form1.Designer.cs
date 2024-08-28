namespace MiPrimerProyecto
{
    using System;
    using System.Collections.Generic;
    using System.IO.Ports;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    namespace miPrimerProyecto
    {
        using System;

        class ProgramaImpuesto
        {
            static void Main()
            {
                // Solicitar al usuario el monto de la actividad económica
                Console.Write("Ingrese el monto de la actividad económica: ");
                double monto = Convert.ToDouble(Console.ReadLine());

                // Calcular el impuesto
                double impuesto = CalcularImpuesto(monto);

                // Mostrar el resultado
                Console.WriteLine($"El impuesto a las actividades económicas para un monto de {monto} es: {impuesto}");
            }

            static double CalcularImpuesto(double monto)
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
                    rango_desde = 8000.01;
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
        }
    }

