using System;
using System.IO;

namespace ejercicio_8_13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            using (BinaryReader fichero = new BinaryReader(File.Open(nombre, FileMode.Open)))
            {
                short dato = fichero.ReadInt16();

                if (dato == 19778)
                    Console.WriteLine("Es una imagen BMP.");
                else
                    Console.WriteLine("No es una imagen BMP.");
            }
        }
    }
}
