using System;
using System.IO;

namespace ejercicio_8_10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int dato;

            Console.Write("Archivo: ");
            nombre = Console.ReadLine();

            using (FileStream fichero = new FileStream(nombre, FileMode.Open))
            {
                using (StreamWriter escritura = new StreamWriter("salida.txt"))
                {
                    while ((dato = fichero.ReadByte()) != -1)
                    {
                        if (dato == 10)
                            escritura.WriteLine("0x0" + dato.ToString("X") + " -> LF");
                        else 
                        if (dato == 13)
                            escritura.WriteLine("0x0" + dato.ToString("X") + " -> LF");
                        else 
                        if (dato >= 32 && dato <= 127)
                            escritura.WriteLine("0x" + dato.ToString("X") + " -> " + Convert.ToChar(dato));
                    }
                }
            }
        }
    }
}
