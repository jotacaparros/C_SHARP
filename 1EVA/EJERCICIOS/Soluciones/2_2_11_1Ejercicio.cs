using System;

public class Ejercicio_2_2_11_1
{
	/*(2.2.11.1) Crea un programa que escriba los números del 20 al 10, descendiendo, 
	excepto el 13, usando "continue"*/
	
	public static void niggA()
	{
		for (int i = 20; i > 9; i-- )
        {
			if (i == 13)
				continue;

			Console.WriteLine(i);

        }
	}
}
