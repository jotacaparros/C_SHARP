using System;
using System.IO;

namespace ejercicio_8_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();
            
            FileStream fichero = File.OpenRead(nombre);
            byte[] cabecera = new byte[128];

            if (fichero.Read(cabecera, 0, 128) == 128)
            {
                int anchura = cabecera[70] * 256 + cabecera[71];
                int altura = cabecera[72] * 256 + cabecera[73];
                int colores = cabecera[3];

                Console.WriteLine("{0} x {1}", Convert.ToString(anchura), Convert.ToString(altura));

                switch (colores)
                {
                    case 1: Console.WriteLine("Monocromo"); break;
                    case 4: Console.WriteLine("16 colores"); break;
                    case 8: Console.WriteLine("256 colores"); break;
                    case 24: Console.WriteLine("16.7 millones de colores o truecolor"); break;
                }
            }
            else
                Console.WriteLine("Error al leer.");

            fichero.Close();
        }
    }
}
