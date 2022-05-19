using System;
using System.IO;

namespace ejercicio_8_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string linea;

            using (StreamReader fichero = new StreamReader("prueba.txt"))
            {
                do
                {
                    linea = fichero.ReadLine();
                    if (linea != null)
                        Console.WriteLine(linea);
                }
                while (linea != null);
            }
        }
    }
}
