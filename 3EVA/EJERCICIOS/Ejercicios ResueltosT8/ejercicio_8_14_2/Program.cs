using System;
using System.IO;

namespace ejercicio_8_14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            FileStream fichero = File.OpenRead(nombre);
            byte[] cabecera = new byte[10];

            if (fichero.Read(cabecera, 0, 128) == 128)
            {
                int anchura = cabecera[7] * 256 + cabecera[6];
                int altura = cabecera[9] * 256 + cabecera[8];

                Console.WriteLine("{0} x {1}", Convert.ToString(anchura), Convert.ToString(altura));
            }
            else
                Console.WriteLine("Error al leer.");

            fichero.Close();
        }
    }
}
