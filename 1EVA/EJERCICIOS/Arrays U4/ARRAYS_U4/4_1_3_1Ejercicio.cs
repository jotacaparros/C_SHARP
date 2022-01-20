using System;

namespace ARRAYS_U4
{
    class Ejercicio_4_1_3_1
    {
        /*(4.1.3.1) Crea un programa que pida al usuario 6 números enteros cortos y luego 
        los muestre en orden inverso (pista: usa un array para almacenarlos y "for" para 
        mostrarlos).*/

        public static void xxx()
        {
            int[] num = new int[6];

            Console.WriteLine("Hola marinero. Dame 6 números.");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Número {0}", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Tus numeros de el último al primero:");

            for(int i = 5; i >= 0 ; i--)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}