using System;

namespace ARRAYS_U4
{
    class Ejercicio_4_1_1_1
    {
        /*(4.1.1.1) Un programa que pida al usuario 4 números, los memorice (utilizando un 
        array), calcule su media aritmética y después muestre en pantalla la media y los 
        datos tecleados.*/
        public static void Media()
        {
            int[] numeros = new int[4];
            int media;

            Console.WriteLine("Hola marinero. Introduce 4 números y hagamos magia juntos ;)");

            numeros[0] = Convert.ToInt32(Console.ReadLine());
            numeros[1] = Convert.ToInt32(Console.ReadLine());
            numeros[2] = Convert.ToInt32(Console.ReadLine());
            numeros[3] = Convert.ToInt32(Console.ReadLine());

            media = (numeros[0] + numeros[1] + numeros[2] + numeros[3]) / 4;

            Console.WriteLine("La media de {0}, {1}, {2}, y {3} es: {4}", numeros[0], numeros[1], numeros[2], numeros[3], media);
        }
    }
}
