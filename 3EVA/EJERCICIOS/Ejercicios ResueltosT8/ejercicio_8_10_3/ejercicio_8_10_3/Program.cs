using System;
using System.IO;

namespace ejercicio_8_10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string palabra;
            char caracter;
            int posicion;
            int dato;

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            Console.Write("Palabra: ");
            palabra = Console.ReadLine();

            posicion = 0;
            using (FileStream fichero = new FileStream(nombre, FileMode.Open))
            {
                while ((dato = fichero.ReadByte()) != -1)
                {
                    caracter = Convert.ToChar(dato);
                    if (palabra[posicion] == caracter)
                        posicion++;
                    else
                        posicion = 0;

                    if (posicion == palabra.Length)
                        break;
                }
            }

            if (posicion == palabra.Length)
                Console.WriteLine("Palabra encontrada.");
            else
                Console.WriteLine("Palabra no encontrada.");
        }
    }
}
