using System;

namespace ARRAYS_U4
{
    class Ejercicio_4_1_1_2
    {
        /*(4.1.1.2) Un programa que pida al usuario 5 números reales (pista: necesitarás un 
        array de "float") y luego los muestre en el orden contrario al que se introdujeron.*/
        public static void DelReves()
        {
            float[] numeros = new float[5];

            Console.WriteLine("Hola marinero. Introduce 5 números y hagamos magia juntos ;)");

            numeros[0] = float.Parse(Console.ReadLine());
            numeros[1] = float.Parse(Console.ReadLine());
            numeros[2] = float.Parse(Console.ReadLine());
            numeros[3] = float.Parse(Console.ReadLine());
            numeros[4] = float.Parse(Console.ReadLine());


            Console.WriteLine("{0} {1} {2} {3} {4}",numeros[4], numeros[3], numeros[2], numeros[1], numeros[0]);
        }
    }
}
