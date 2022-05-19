using System;
using System.IO;

namespace ejercicio_8_13_1
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

                if (dato == 23117)
                    Console.WriteLine("Es un ejecutable.");
                else
                    Console.WriteLine("No es un ejecutable.");
            }

        }
    }
}
