using System;
using System.IO;

namespace ejercicio_8._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero = File.OpenText("registroDeUsuario.txt");

            for (int i = 0; i < 3; i++)
                Console.WriteLine(fichero.ReadLine());
        }
    }
}
