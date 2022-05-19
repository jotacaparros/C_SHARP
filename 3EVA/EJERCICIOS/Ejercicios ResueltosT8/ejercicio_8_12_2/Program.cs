using System;
using System.IO;

namespace ejercicio_8_12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            byte[] datos = new byte[1];

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            using (FileStream fichero = new FileStream(nombre, FileMode.Open))
            {
                fichero.Seek(30, SeekOrigin.Begin);
                if (fichero.Read(datos, 0, 1) == 1)
                {
                    int compresion = Convert.ToInt32(datos[0]);
                    switch (compresion)
                    {
                        case 0:
                            Console.WriteLine("Sin compresión.");
                            break;
                        case 1:
                            Console.WriteLine("Compresión RLE 8 bits.");
                            break;
                        case 2:
                            Console.WriteLine("Compresión RLE 4 bits.");
                            break;
                        default:
                            Console.WriteLine("Compresión desconocida.");
                            break;
                    }
                }
                else
                    Console.WriteLine("Error al leer.");
            }
        }
    }
}
