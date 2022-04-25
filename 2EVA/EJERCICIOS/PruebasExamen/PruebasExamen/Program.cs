using System;

namespace PruebasExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generadoRandom = new Random();

            int numeroRandom;
            char letraAleatoria;
            numeroRandom = generadoRandom.Next(97, 123);
            

            Console.WriteLine(numeroRandom);

            Console.WriteLine(letraAleatoria = Convert.ToChar(numeroRandom));
            numeroRandom = generadoRandom.Next(65, 91);

            Console.WriteLine(numeroRandom);

            Console.WriteLine(letraAleatoria = Convert.ToChar(numeroRandom));
        }
    }
}
