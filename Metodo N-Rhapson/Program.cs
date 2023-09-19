using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_N_Rhapson
{
    internal class Program
    {

     
        static double f(double x)
        {
            return x * Math.Log(x) - 5;
        }

 
        static double df(double x)
        {
            return Math.Log(x) + 1;
        }

        static void Main()
        {
            int maxIteraciones = 10;
            double x0 = 4.0;
            double x = x0;
            double errorRelativo;

            Console.WriteLine("Iteración\tValor de x\tError Relativo");

            for (int i = 0; i < maxIteraciones; i++)
            {
                double f_x = f(x);
                double df_x = df(x);

            
                if (df_x == 0)
                {
                    Console.WriteLine("No se puede continuar debido a la derivada igual a cero.");
                    break;
                }

               
                double xNuevo = x - f_x / df_x;

               
                if (x != 0)
                {
                    errorRelativo = Math.Abs((xNuevo - x) / xNuevo) * 100;
                }
                else
                {
                    errorRelativo = Math.Abs(xNuevo - x) * 100;
                }

                Console.WriteLine($"{i + 1}\t\t{xNuevo:F8}\t{errorRelativo:F8}%");


                x = xNuevo;
            }
        }
    }
}

