using System;

public class Ejercicio_2_1_9_3
{
	/*(2.1.9.3) Crea un programa que lea una letra tecleada por el usuario y diga si se
	trata de una vocal, una cifra numérica o una consonante, usando "switch".*/

	public static void xxx()
	{
		char caracter;
		Console.WriteLine("Introduce un carácter y te digo que es.");
		
		caracter = Convert.ToChar(Console.ReadLine());
		
			switch (caracter)
			{
				case 'a': case 'e': case 'i': case 'o': case 'u': Console.WriteLine("Vocal");
				break;
				
				case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9':
				Console.WriteLine("cifra númerica");
				break;
			
				default: Console.WriteLine("consonante");
				break;
			}

	}
}
