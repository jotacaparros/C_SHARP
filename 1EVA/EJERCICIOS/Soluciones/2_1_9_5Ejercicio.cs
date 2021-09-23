using System;

public class Ejercicio_2_1_9_5
{
	/*Crea un programa que lea una letra tecleada por el usuario y diga si se
	trata de un signo de puntuación (. , ; :), una cifra numérica (del 0 al 9) o algún otro
	carácter, usando "switch" (pista: habrá que usar un dato de tipo "char").
	
	(2.1.9.5) Repite el ejercicio 2.1.9.2, empleando "if" en lugar de "switch" (pista: como
	las cfras numéricas del 0 al 9 están ordenadas, no hace falta comprobar los 10
	valores, sino que se puede hacer con "if ((simbolo >= '0') && (simbolo <='9'))").*/

	public static void xxxx()
	{
		char caracter;
		Console.WriteLine("Introduce un carácter y te digo que es.");
		
		caracter = Convert.ToChar(Console.ReadLine());
		
			if ((caracter >= '0') && (caracter <= '9'))
			{
				Console.WriteLine("{0} es un número", caracter);
			}
				else
				{
					if(caracter == ',' || caracter == ';' || caracter == '.' || caracter == ':')
					{
						Console.WriteLine("{0} es un símbolo de puntación", caracter);
					}
						else 
						{
							Console.WriteLine("{0} es otro tipo de carácter", caracter);
						}
		        }

	}
}
