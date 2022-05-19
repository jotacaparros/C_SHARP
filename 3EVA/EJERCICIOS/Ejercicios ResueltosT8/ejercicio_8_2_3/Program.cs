using System;
using System.IO;

namespace ejercicio_8_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader fichero = new StreamReader("registroDeUsuario.txt"))
            {
                for (int i = 0; i < 3; i++)
                    Console.WriteLine(fichero.ReadLine());
            }
        }
    }
}
