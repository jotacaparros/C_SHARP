using System;

public class Ejercicio_2_1_9_2
{
	/*(2.1.9.2) Crea un programa que lea una letra tecleada por el usuario y diga si se
	trata de un signo de puntuación (. , ; :), una cifra numérica (del 0 al 9) o algún otro
	carácter, usando "switch" (pista: habrá que usar un dato de tipo "char").*/

	public static void xxx()
	{
		char caracter;
		Console.WriteLine("Introduce un carácter y te digo que es.");
		
		caracter = Convert.ToChar(Console.ReadLine());
		
			switch (caracter)
			{
				case ',': case '.': case ';': case ':': Console.WriteLine("Signo de puntuación");
				break;
				
				case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9':
				Console.WriteLine("cifra númerica");
				break;
			
				default: Console.WriteLine("letra");
				break;
			}

	}
}
