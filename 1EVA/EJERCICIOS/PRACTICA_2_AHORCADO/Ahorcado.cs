// --------------------------------------------
// Nombre del alumno
// Curso DAW/DAM
// Modalidad Presencial/Semipresencial
// Práctica nº 2
// --------------------------------------------

using System;
using System.Text;

namespace PRACTICA_2_AHORCADO
{
    class Ahorcado
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una palabra: ");
            StringBuilder adivina = new StringBuilder(Console.ReadLine());
            string oculto;
            oculto = adivina.ToString();

            for (int i = 0; i < adivina.Length; i++)
            {
                adivina[i] = '_';
            }

              Console.WriteLine(adivina);
              Console.WriteLine(oculto);




        }
    }
}
