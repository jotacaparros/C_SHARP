using System;
using System.IO;

namespace ejercicio_8._1._1_console
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero;
            String texto;

            /*
            fichero = new StreamWriter("registroDeUsuario.txt");

            Console.Write("Texto: ");
            texto = Console.ReadLine();

            while (texto.ToLower() != "fin")
            {
                fichero.WriteLine(texto);

                Console.Write("Texto: ");
                texto = Console.ReadLine();
            }

            fichero.Close();
            */

            using (fichero = new StreamWriter("registroDeUsuario.txt"))
            {
                Console.Write("Texto: ");
                texto = Console.ReadLine();

                while (texto.ToLower() != "fin")
                {
                    fichero.WriteLine(texto);

                    Console.Write("Texto: ");
                    texto = Console.ReadLine();
                }
            }
        }
    }
}
