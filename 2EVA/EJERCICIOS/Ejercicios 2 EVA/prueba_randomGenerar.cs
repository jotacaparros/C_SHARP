using System;
namespace Ejercicios_2_EVA
{
    public class prueba_randomGenerar
    {

    public static void Main()
        {
            Random generadoRandom = new Random();

            int numeroRandom;
            char letraAleatoria;
            numeroRandom = generadoRandom.Next(97, 123);

            Console.WriteLine(numeroRandom);

            Console.WriteLine(letraAleatoria = Convert.ToChar(numeroRandom));



        }
     
    }
}
