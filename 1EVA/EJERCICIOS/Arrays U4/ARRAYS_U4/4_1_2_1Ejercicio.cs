using System;

namespace ARRAYS_U4
{
    class Ejercicio_4_1_2_1
    {
        /*(4.1.2.1) Un programa que almacene en una tabla el número de días que tiene 
        cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique 
        un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que 
        tiene ese mes.*/
        public static void Meses()
        {
           int[] mes = new int[13] {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            int i = 0;


            Console.WriteLine("Hola marinero. Dame un mes y te digo cuantos días tiene (1=enero, 12=diciembre).");

            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tiene {0} días", mes[i]);
        }
    }
}
