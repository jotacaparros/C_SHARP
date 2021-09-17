using System;

public class Ejercicio_2_1_1_3
{
	/*(2.1.1.3) Crea un programa que pida al usuario dos números enteros y diga si el
	primero es múltiplo del segundo (pista: igual que antes, habrá que ver si el resto
	de la división es cero: a % b == 0). */

	public static void xxx()
	{
		int numUsuario1, numUsuario2;

		Console.WriteLine("Entregame dos números, humano");

			numUsuario1 = Convert.ToInt32(Console.ReadLine());
			numUsuario2 = Convert.ToInt32(Console.ReadLine());

		if (numUsuario1 % numUsuario2 == 0)
        {
			Console.WriteLine("HUMANO! {0} es múltiplo de {1}. Utiliza sabiamente esta información.", numUsuario1, numUsuario2);
        }
			else
			{
			Console.WriteLine("HUMANO! {0} NO! es múltiplo de {1}. Utiliza sabiamente esta información.", numUsuario1, numUsuario2);
		}

	}
}
