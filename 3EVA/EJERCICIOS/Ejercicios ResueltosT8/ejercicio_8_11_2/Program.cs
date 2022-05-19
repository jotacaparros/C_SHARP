using System;
using System.IO;

namespace ejercicio_8_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            byte[] datos = new byte[2];

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            using (FileStream fichero = new FileStream(nombre, FileMode.Open))
            {
                if (fichero.Read(datos, 0, 2) == 2)
                {
                    if (Convert.ToChar(datos[0]) == 'B' && Convert.ToChar(datos[1]) == 'M')
                        Console.WriteLine("Es una imagen BMP.");
                    else
                        Console.WriteLine("No es una imagen BMP.");
                }
                else
                    Console.WriteLine("Error al leer.");
            }
        }
    }
}
