using System;

public class Ejercicio_2_1_1_2
{
	/* (2.1.1.2) Crea un programa que pida al usuario dos números enteros y diga cuál es
	el mayor de ellos. */

	public static void xxxx()
	{
		int numUsuario1, numUsuario2;

		Console.WriteLine("Elige dos números");

		numUsuario1 = Convert.ToInt32(Console.ReadLine());
		numUsuario2 = Convert.ToInt32(Console.ReadLine());

		if (numUsuario1 == numUsuario2)
		{
			Console.WriteLine("{0} es igual que {1}", numUsuario2, numUsuario1);
		}

		else
		{
			if (numUsuario1 > numUsuario2)
			{
				Console.WriteLine("{0} es mayor que {1}", numUsuario1, numUsuario2);
			}
			else
			{
				Console.WriteLine("{0} es mayor que {1}", numUsuario2, numUsuario1);
			}
		}		
		
	}
}
