using System;
using System.IO;

/*
 Abre una imagen en formato BMP y comprueba si está comprimida, 
mirando el valor del byte en la posición 30 (empezando a contar desde 0). Si ese 
valor es un 0 (que es lo habitual), indicará que el fichero no está comprimido.
Deberás leer toda la cabecera (los primeros 54 bytes) con una sola orden.
*/

namespace ejercicio_8_11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            byte[] datos = new byte[54];

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            using (FileStream fichero = new FileStream(nombre, FileMode.Open))
            {
                if (fichero.Read(datos, 0, 54) == 54)
                {
                    if (Convert.ToChar(datos[0]) == 'B' && Convert.ToChar(datos[1]) == 'M')
                    {
                        if (datos[30] == 0)
                            Console.WriteLine("No está comprimido.");
                        else
                            Console.WriteLine("Está comprimido.");


                        for (int i = 0; i < 54; i++)
                        {
                            if (datos[i] < 16)
                                Console.WriteLine("{0} 0x0{1} ", i, datos[i].ToString("X"));
                            else
                                Console.WriteLine("{0} 0x{1} ", i, datos[i].ToString("X"));
                        }
                    }
                    else
                        Console.WriteLine("No es una imagen BMP.");
                }
                else
                    Console.WriteLine("Error al leer.");
            }
        }
    }
}
