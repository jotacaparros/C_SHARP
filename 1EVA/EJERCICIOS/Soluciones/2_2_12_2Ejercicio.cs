using System;

public class Ejercicio_2_2_12_2
{
	/*(2.2.12.2) Crea un programa que escriba los números pares del 20 al 10, 
	descendiendo, excepto el 14, primero con "for" y luego con "while"*/

	public static void takeMyAway()
	{
		for (int i = 20; i >= 10; i = i - 2)
        {
			if (i == 14)
				continue;
			Console.Write("{0} ", i);
		}

		Console.WriteLine();

		int j = 22;
		while ( j != 10)
		{
			j = j - 2;
			if (j == 14)
				continue;
			Console.Write("{0} ", j);

		}
	}
}
