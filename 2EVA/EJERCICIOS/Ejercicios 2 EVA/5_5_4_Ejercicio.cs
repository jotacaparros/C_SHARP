using System;
namespace Ejercicios_2_EVA
{
    public class Ejercicio_5_5_4
    {
        /*(5.5.4) Crea una función "ContarLetra", que reciba una cadena y una letra, 
        y devuelva la cantidad de veces que dicha letra aparece en la cadena.
        Por ejemplo, si la cadena es "Barcelona" y la letra es 'a', debería devolver 2
        (porque la "a" aparece 2 veces).*/

        public static void xxx()
        {
            Console.WriteLine("Escribe:");
            string escribo = Console.ReadLine();
            Console.WriteLine(ContarLetra(escribo)); 

        }

        public static int ContarLetra(string x)
        {
            int contador = 0;
            Console.WriteLine("Letra");
            char letra = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < x.Length; i++)
            {
                if ( x[i] == letra)
                {
                    contador++;
                }
            }

            return contador;

        }
    }
}
