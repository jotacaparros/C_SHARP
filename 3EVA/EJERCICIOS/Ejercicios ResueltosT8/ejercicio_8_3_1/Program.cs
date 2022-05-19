using System;
using System.IO;

namespace ejercicio_8_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero;
            string linea;

            fichero = new StreamReader("prueba.txt");
            do
            {
                linea = fichero.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);
            }
            while (linea != null);
            fichero.Close();
        }
    }
}
