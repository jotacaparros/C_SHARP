using System;
using System.IO;

namespace ejercicio_8_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int letraA = 0;
            int letraE = 0;
            int letraI = 0;
            int letraO = 0;
            int letraU = 0;
            int dato;
            bool existe;

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            using (FileStream fichero = new FileStream(nombre, FileMode.Open))
            {
                while ((dato = fichero.ReadByte()) != -1)
                {
                    switch (Convert.ToChar(dato))
                    {
                        case 'A':
                        case 'a':
                            letraA++;
                            break;
                        case 'E':
                        case 'e':
                            letraE++;
                            break;
                        case 'I':
                        case 'i':
                            letraI++;
                            break;
                        case 'O':
                        case 'o':
                            letraO++;
                            break;
                        case 'U':
                        case 'u':
                            letraU++;
                            break;
                    }
                }
            }

            Console.WriteLine("El fichero {0} contiene:", nombre);
            Console.WriteLine(" - Letra A, a: {0} veces.", letraA);
            Console.WriteLine(" - Letra E, e: {0} veces.", letraE);
            Console.WriteLine(" - Letra I, i: {0} veces.", letraI);
            Console.WriteLine(" - Letra O, o: {0} veces.", letraO);
            Console.WriteLine(" - Letra U, u: {0} veces.", letraU);
        }
    }
}
