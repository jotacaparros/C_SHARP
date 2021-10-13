using System;
namespace Soluciones
{
    public class Ejercicio_2_6_6
    {
        /*(2.6.6) Crea un programa que "dibuje" un rectángulo hueco, cuyo borde sea una
        fila (o columna) de asteriscos y cuyo interior esté formado por espacios en blanco,
        con el ancho y el alto que indique el usuario. Por ejemplo, si desea anchura 4 y altura 3,
        el rectángulo sería así:
        ****
        *  *
        **** */

        public static void UnVacioInterior()
        {
            int alt, anch;

            Console.WriteLine("Ancho:");
            anch = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Alto:");
            alt = Convert.ToInt32(Console.ReadLine());

            //Esto para medir la altura
            for (int i = 0; i < alt; i++)
            {
                //Esto para escribir a lo ancho
                for (int j = 0; j < anch; j++)
                {
                    //Queremos que la primera linea y la última llena de *
                    if (i == 0 || i == alt - 1)
                    {
                        Console.Write("*");
                    }
                        else
                        {
                        //Y que dentro haya espacios excepto el primero y último de cada linea
                            if (j == 0 || j == anch - 1)
                            {
                                Console.Write("*");
                             }
                                 else
                                    Console.Write(" ");

                        }

                }

               Console.WriteLine("");
            }
        }
    }
}
