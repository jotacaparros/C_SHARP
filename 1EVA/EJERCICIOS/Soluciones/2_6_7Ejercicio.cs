using System;
namespace Soluciones
{
    public class Ejercicio_2_6_7
    {
        /*(2.6.7) Crea un programa que "dibuje" un triángulo creciente, alineado a la
        derecha, con la altura que indique el usuario. Por ejemplo, si el usuario dice
        que desea 4 caracteres de alto, el triángulo sería así:
            * 
           **
          *** 
         **** 
                */
        public static void Main()
        {
            int alt, anch;

            Console.WriteLine("Ancho:");
            anch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Alto:");
            alt = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < alt; i++)
            {
                for (int j = 0; j < anch; j++)
                {

                }
            }
        }
    }
}
