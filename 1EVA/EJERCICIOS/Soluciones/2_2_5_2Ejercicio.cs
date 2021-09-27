using System;

public class Ejercicio_2_2_5_2
{
	/*2.2.5.2) Crea un programa escriba 4 veces los números del 1 al 5, en una misma 
	línea, usando "while": 12345123451234512345.*/
	
	public static void xxx()
	{
		int i = 0, j = 1, k = 1, l = 1;

		while  (i != 5)
		{
			while (j  != 6)
			{
				Console.Write(j);
				j++;
			}

			i++;
			Console.Write(i);

			while (k != 6)
			{
				Console.Write(k);
				k++;
			}
			while (l != 6)
			{
				Console.Write(l);
				l++;
			}

		}
	}
}
