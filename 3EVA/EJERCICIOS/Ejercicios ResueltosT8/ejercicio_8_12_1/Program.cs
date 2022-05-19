using System;
using System.IO;

namespace ejercicio_8_12_1
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
                fichero.Seek(1, SeekOrigin.Begin);
                if (fichero.Read(datos, 0, 1) == 1)
                {
                    if (Convert.ToChar(datos[0]) == 'Z')
                        Console.WriteLine("Es un ejecutable.");
                    else
                        Console.WriteLine("No es un ejecutable.");
                }
                else
                    Console.WriteLine("Error al leer.");
            }

        }
    }
}
