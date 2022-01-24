using System;
namespace Ejercicios_2_EVA
{
    public class Ejercicio_5_5_3
    {
        /*(5.5.3) Crea una función "EsPrimo", que reciba un número y devuelva el valor booleano
        "true" si es un número primo o "false" en caso contrario.*/

        public static void xxx()
        {
            bool primo;
            Console.WriteLine("Número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            primo = EsPrimo(numero);
            if (primo == true)
            {
                Console.WriteLine("Es primo");
            }else
            {
                Console.WriteLine("No es primo");
            }

        }

        public static bool EsPrimo(int x)
        {
            int a = 0;
            for( int i= 1; i<= x; i++)
            {
                if(x % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
