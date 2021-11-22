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
            string ahorcado5 = @"
┌───┐
│   o
|  
│
│
┴───────
            ";
            string ahorcado4 = @"
┌───┐
│   o
|  /
│
│
┴───────
            ";
            string ahorcado3 = @"
┌───┐
│   o
|  /|
│
│
┴───────
            ";
            string ahorcado2 = @"
┌───┐
│   o
|  /|\
│
│
┴───────
            ";
            string ahorcado1 = @"
┌───┐
│   o
|  /|\
│  /
│
┴───────
            ";
            string ahorcado0 = @"
┌───┐
│   o
|  /|\
│  / \
│
┴───────
            ";


            

            Console.Write("Introduce una palabra: ");
            StringBuilder adivina = new StringBuilder(Console.ReadLine());
            string oculto;
            char letra;
            int inicio = 0, vidas = 3;
            oculto = adivina.ToString();

        
            for (int i = 0; i < adivina.Length; i++)
            {
                adivina[i] = '_' ;
                Console.Write("{0} ", adivina[i]);
            }

            Console.Write("Letra: ");

            letra = Convert.ToChar(Console.ReadLine());


            if(oculto.Contains(letra))
            {
                do
                {
                    inicio = oculto.IndexOf(letra, inicio);                    
                    if (inicio != -1) adivina[inicio] = letra;                                                   
                    if( inicio >= 0) inicio++;
                }
                while (inicio != -1);

                for (int i = 0; i < adivina.Length; i++)
                {
                    Console.Write("{0} ", adivina[i]);
                }
            }
            else
            {
                vidas--;

                switch (vidas)
                {
                    case 5:
                        Console.WriteLine(ahorcado5);
                        break;
                    case 4:
                        Console.WriteLine(ahorcado4);
                        break;
                    case 3:
                        Console.WriteLine(ahorcado3);
                        break;
                    case 2:
                        Console.WriteLine(ahorcado2);
                        break;
                    case 1:
                        Console.WriteLine(ahorcado1);
                        break;
                    case 0:
                        Console.WriteLine(ahorcado0);
                        break;
                }


            }

            



        }
    }
}
