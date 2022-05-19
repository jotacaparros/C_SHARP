using System;
using System.IO;

namespace ejercicio_8_9_1
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

                if ((char1 == 'M') && (char2 == 'Z'))
                {
                    Console.WriteLine("Es un fichero binario.");
                }
                else
                {
                    Console.WriteLine("No es un fichero binario.");
                }
            }
        }
    }
}
