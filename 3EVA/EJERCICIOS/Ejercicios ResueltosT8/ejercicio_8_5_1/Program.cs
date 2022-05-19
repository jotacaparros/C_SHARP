using System;
using System.IO;

namespace ejercicio_8_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter fichero = new StreamWriter(@".\resultados\suma.txt", true))
            {
                int sumando1 = 0;
                int sumando2 = 0;
                int resultado = 0;

                Console.Write("Sumando 1: ");
                sumando1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sumando 2: ");
                sumando2 = Convert.ToInt32(Console.ReadLine());

                resultado = sumando1 + sumando2;

                fichero.WriteLine("{0} + {1} = {2}", sumando1, sumando2, resultado);
            }
        }
    }
}
