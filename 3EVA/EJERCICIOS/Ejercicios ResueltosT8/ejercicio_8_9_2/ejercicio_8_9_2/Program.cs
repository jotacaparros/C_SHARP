using System;
using System.IO;

namespace ejercicio_8_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            using (FileStream fichero = new FileStream(nombre, FileMode.Open))
            {
                char char1 = Convert.ToChar(fichero.ReadByte());
                char char2 = Convert.ToChar(fichero.ReadByte());

                if ((char1 == 'B') && (char2 == 'M'))
                {
                    Console.WriteLine("Es un fichero BMP.");
                }
                else
                {
                    Console.WriteLine("No es un fichero BMP.");
                }
            }
        }
    }
}
