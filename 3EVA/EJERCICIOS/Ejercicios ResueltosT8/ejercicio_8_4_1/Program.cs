using System;
using System.IO;

namespace ejercicio_8_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter fichero = new StreamWriter("log.txt", true))
            {
                string texto = "";

                Console.Write("Texto: ");

                while ((texto = Console.ReadLine()) != "")
                {
                    fichero.WriteLine(texto);

                    Console.Write("Texto: ");
                }
            }
        }
    }
}
