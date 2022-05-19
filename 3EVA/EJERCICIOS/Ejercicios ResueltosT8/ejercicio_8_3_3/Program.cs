using System;
using System.IO;

namespace ejercicio_8_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int linea = 0;
            string nombreFichero = "";
            string cadena = "";

            Console.Write("Fichero: ");
            nombreFichero = Console.ReadLine();

            using (StreamReader fichero = new StreamReader(nombreFichero))
            {
                while ((cadena = fichero.ReadLine()) != null)
                {
                    linea++;

                    if (linea % 24 == 0)
                    {
                        Console.Write("Pulsa intro para continuar...");
                        Console.ReadLine();
                    }

                    Console.WriteLine(cadena);
                }
            }

        }
    }
}
