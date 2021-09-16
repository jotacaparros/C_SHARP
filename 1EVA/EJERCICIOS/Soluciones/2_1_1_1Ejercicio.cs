using System;

public class Ejercicio_2_1_1_1
{
	/*(2.1.1.1) Crea un programa que pida al usuario un número entero y diga si es par
	(pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero:
	if (x % 2 == 0) …). */

	public static void xxxx()
	{

		int numUsuario;

		Console.WriteLine("INSERTA UN NÚMERO");

		numUsuario = Convert.ToInt32(Console.ReadLine());

		if (numUsuario % 2 == 0) 
		{
			Console.WriteLine("TU NÚMERO ES PAR.");
		}
			else 
			{
				Console.WriteLine("TU NÚMERO NO ES PAR.");
			}




	}
}
