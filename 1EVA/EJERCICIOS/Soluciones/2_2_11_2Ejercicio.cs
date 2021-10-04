using System;

public class Ejercicio_2_2_11_2
{
	/*(2.2.11.2) Crea un programa que escriba los números pares del 2 al 106, excepto 
	los que sean múltiplos de 10, usando "continue".*/

	public static void pazzz()
	{
		for (int i = 2; i < 107; i = i + 2)
        {
			if (i == 10 || i == 20 || i == 30 || i == 40 || i == 50 || i == 60 || i == 70 || i == 80 || i == 90 || i == 100)
				continue;

			Console.WriteLine(i);
		}
	}
}
