using System;

public class Ejercicio_2_5_1
{
	/*(2.5.1) Crea un programa que cuente cuantas veces aparece la letra 'a' en una 
	frase que teclee el usuario, utilizando "foreach".
	*/
	public static void UnNombre()
	{
		Console.WriteLine("Un ordenador, necesita un nombre:");
		string palabra = Convert.ToString(Console.ReadLine());
		int contador = 0;


			foreach (char letra in palabra)
			{
			if (letra == 'a' || letra == 'A')
				{
					contador++;
				}
			}
		Console.WriteLine("Un nombre tiene {0} a", contador);
	}	
}