using System;
using System.IO;

namespace ejercicio_8_7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreFichero1;
            string nombreFichero2;
            StreamReader ficheroReader;
            StreamWriter ficheroWriter;
            string cadena;

            Console.Write("Fichero origen: ");
            nombreFichero1 = Console.ReadLine();

            Console.Write("Fichero destino: ");
            nombreFichero2 = Console.ReadLine();

            try
            {
                using (ficheroReader = new StreamReader(nombreFichero1))
                {
                    using (ficheroWriter = new StreamWriter(nombreFichero2))
                    {
                        while ((cadena = ficheroReader.ReadLine()) != null)
                            ficheroWriter.WriteLine(cadena.ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
