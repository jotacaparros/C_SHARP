using System;
namespace Soluciones
{
    public class Ejercicio_2_6_5
    {
        /*(2.6.5) Crea un programa que "dibuje" un triángulo decreciente, con la altura que
        indique el usuario. Por ejemplo, si el usuario dice que desea 4 caracteres de alto, el
        triángulo sería así:
        ****
        ***
        **
        *   */

        public static void IluminatiConfirmed()
        {
            int ancho;
            Console.WriteLine("Dame la base:");
            ancho = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ancho; i++)
            {
                for (int j = ancho; j > i  ; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
