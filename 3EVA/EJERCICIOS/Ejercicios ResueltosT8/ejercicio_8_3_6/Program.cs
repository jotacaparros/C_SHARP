using System;
using System.IO;

namespace ejercicio_8_3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreFichero = "";
            string cadenaBuscar = "";
            string cadena = "";
            int linea = 0;

            Console.Write("Fichero: ");
            nombreFichero = Console.ReadLine();

            Console.Write("Cadena a buscar: ");
            cadenaBuscar = Console.ReadLine();

            using (StreamReader fichero = new StreamReader(nombreFichero))
            {
                while ((cadena = fichero.ReadLine()) != null)
                {
                    if (cadena.IndexOf(cadenaBuscar) > 0)
                    {
                        Console.WriteLine(linea + " - " + cadena);
                    }

                    linea++;
                }
            }
        }
    }
}
