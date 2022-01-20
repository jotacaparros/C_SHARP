using System;

    public class Ejercicio_5_4_3
    {
        /*(5.4.3) Crea una función llamada "Signo", que reciba un número real, y devuelva un número entero con el valor:
         * -1 si el número es negativo, 1 si es positivo o 0 si es cero.*/

        public static void xxx()
        {
            float numero;

            Console.WriteLine("Escribe un número y te diré si es negativo positivo o cero");

            numero = float.Parse(Console.ReadLine());
            Console.WriteLine(Signo(numero));

        }

        public static int Signo(float x)
        {
            int y;
            if ( x > 0)
            {
                y = 1;
            }else
            {
                if ( x < 0)
                {
                    y = -1;
                }else
                {
                    y = 0;
                }
            }

            return y ;
        }
    }

