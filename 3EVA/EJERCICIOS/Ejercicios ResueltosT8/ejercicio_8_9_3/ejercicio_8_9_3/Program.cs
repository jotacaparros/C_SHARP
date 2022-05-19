using System;
using System.IO;

namespace ejercicio_8_9_3
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
                char char3 = Convert.ToChar(fichero.ReadByte());

                if ((char1 == 'G') && (char2 == 'I') && (char3 == 'F'))
                {
                    Console.WriteLine("Es un fichero GIF.");
                }
                else
                {
                    Console.WriteLine("No es un fichero GIF.");
                }
            }
        }
    }
}
