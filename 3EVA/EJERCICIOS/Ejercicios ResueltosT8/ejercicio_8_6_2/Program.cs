using System;
using System.IO;

namespace ejercicio_8_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader fichero; 
            string nombre;
            bool terminar = false;
            
            while (!terminar) // Interrumpimos desde dentro con "break" 
            { 
                Console.Write("¿Nombre del fichero (\"fin\" para terminar)? "); 
                nombre = Console.ReadLine();

                if (nombre == "fin")
                    terminar = true;
                else
                {
                    if (File.Exists(nombre))
                    {
                        fichero = File.OpenText(nombre);
                        Console.WriteLine("Su primera linea es: {0}", fichero.ReadLine());
                        fichero.Close();
                    }
                    else
                        Console.WriteLine("¡No existe!");
                }
            }
        }
    }
}
