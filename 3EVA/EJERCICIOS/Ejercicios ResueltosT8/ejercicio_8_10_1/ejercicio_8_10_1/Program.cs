using System;
using System.IO;

namespace ejercicio_8_10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            char letra;
            int dato;
            bool existe;

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            Console.Write("Letra: ");
            letra = Convert.ToChar(Console.ReadLine());

            existe = false;

            using (FileStream fichero = new FileStream(nombre, FileMode.Open))
            {
                while ((dato = fichero.ReadByte()) != -1)
                {
                    if (letra == Convert.ToChar(dato))
                        existe = true;
                }
            }

            if (existe)
                Console.WriteLine("La letra {0} existe.", letra);
            else
                Console.WriteLine("La letra {0} no existe.", letra);
        }    
    }
}
