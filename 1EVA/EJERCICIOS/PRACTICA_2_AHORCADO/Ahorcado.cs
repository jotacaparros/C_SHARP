
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
            //Variables para los dibujos
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
            //Variable de la palabra que voy a utilizar como contenedora
            string oculto;
            char letra;
            //V. para posiciones de las cadenas y un contador de intentos
            int posicion, vidas = 6;
            //V. para romper bucles
            bool salirMal = true, salirBien = true;

            Console.Write("Introduce una palabra: ");
            //V. para modificar la palabra con "_" y letras que introduzca el usuario
            StringBuilder adivina = new StringBuilder(Console.ReadLine());
            //igualo variables
            oculto = adivina.ToString();
            //Lo transformo en minus. para poder comparar 
            oculto = oculto.ToLower();
            
            //Bucle para ocultar la palabra
            for (int i = 0; i < adivina.Length; i++)
            {
                adivina[i] = '_';
                Console.Write("{0} ", adivina[i]);
            }

            //Bucle del ahorcado
            do
            {
                Console.WriteLine();
                //Try catch para que solo introduzca char
                try
                {
                    //Bucle para que introduzca chars validos
                    do
                    {
                        Console.Write("Letra: ");
                        letra = Convert.ToChar(Console.ReadLine());
                        if ((letra >= 'A' && letra <= 'Z') || (letra >= 'a' && letra <= 'z') || (letra >= 'Á' && letra <= 'ú'))
                        {
                            salirBien = false;
                        }
                        else Console.WriteLine("Solo puedes introducir una letra");
                    } while (salirBien == true);
                    //Reinicio booleano para que no salga la próxima vez
                    salirBien = true;
                    //Inicio la posición desde donde buscar
                    posicion = 0;
                    //Y la transformo en minus. para poder comparar sin problemas
                    letra = char.ToLower(letra);
                    //Si acierta la letra
                    if (oculto.Contains(letra))
                    {
                        //Busca la posición de la letra y la cambia 
                        do
                        {
                            posicion = oculto.IndexOf(letra, posicion);
                            if (posicion != -1)
                            {
                                adivina[posicion] = letra;
                                //Si adivina la primera letra se la pongo en mayus.
                                if (posicion == 0) adivina[0] = char.ToUpper(letra);
                            }
                            if (posicion >= 0) posicion++;
                        }while (posicion != -1);
                        //Imprimo variable y convierto en minus. la primera para comparar
                        for (int i = 0; i < adivina.Length; i++)
                        {
                            Console.Write("{0} ", adivina[i]);
                            adivina[0]= char.ToLower(adivina[0]);
                        }
                        //Si ha acertado la palabra imprimos felicitaciones y rompemos el bucle
                        if (adivina.Equals(oculto))
                        {
                            Console.WriteLine(@"
                            ");
                            Console.WriteLine("¡ENHORABUENA CRACK HAS GANADO!");
                            salirMal = false;
                        }
                        //Si aun no ha acertado vuelvo a poner la primera letra en mayus. para la próxima que imprima
                        adivina[0] = char.ToUpper(adivina[0]);
                    }
                    //Si no acierta
                    else
                    {
                        //restamos contador e imprimimos ahorcado
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
                            salirMal = false;
                            break;
                        }
                        for (int i = 0; i < adivina.Length; i++)
                        {
                            Console.Write("{0} ", adivina[i]);
                        }
                        Console.WriteLine();
                        if (vidas == 0) Console.WriteLine("R.I.P. La palabra era {0}",oculto);   
                    }      
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Introduce solo una letra");
                }
            }
            while (salirMal == true);
            Console.WriteLine("----FIN----");
        }
    }
}
