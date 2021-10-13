using System;
namespace Soluciones
{
    public class Ejercicio_2_6_4
    {
        /*(2.6.4) Crea un programa que "dibuje" un rectángulo formado por asteriscos, con
        el ancho y el alto que indique el usuario, usando dos "for" anidados. Por ejemplo,
        si desea anchura 4 y altura 3, el rectángulo sería así:
        ****
        ****
        ****    */
        public static void Asteriscos1()
        {

            int ancho, alto;

            Console.WriteLine("Dame el ancho:");
            ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el alto:");
            alto = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < alto; i++)
            {
                for (int j = 0; j < ancho; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
