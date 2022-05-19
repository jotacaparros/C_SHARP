using System;
using System.IO;

namespace ejercicio_8_11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            byte[] datos = new byte[3];

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            using (FileStream fichero = new FileStream(nombre, FileMode.Open))
            {
                if (fichero.Read(datos, 0, 3) == 3)
                {
                    if (Convert.ToChar(datos[0]) == 'G' &&
                        Convert.ToChar(datos[1]) == 'I' &&
                        Convert.ToChar(datos[2]) == 'F')
                        Console.WriteLine("Es una imagen GIF.");
                    else
                        Console.WriteLine("No es una imagen GIF.");
                }
                else
                    Console.WriteLine("Error al leer.");
            }
        }
    }
}
