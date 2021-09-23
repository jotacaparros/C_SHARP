using System;

public class Ejercicio_2_2_1_1_3
{
	/*(2.2.1.1.3) Crea un programa que pida de forma repetitiva pares de números al
	usuario. Tras introducir cada par de números, responderá si el primero es múltiplo
	del segundo
	
	 (2.2.1.1.4) Crea una versión mejorada del programa anterior, que, tras introducir
	cada par de números, responderá si el primero es múltiplo del segundo, o el
	segundo es múltiplo del primero, o ninguno de ellos es múltiplo del otro.*/

	public static void xxx()
	{
		int primer, segundo, multiplo;
		
		Console.WriteLine("Dame dos números y te diré si son múltiplos");

		primer = Convert.ToInt32(Console.ReadLine());
		segundo = Convert.ToInt32(Console.ReadLine());

		while (primer != 0 || segundo != 0)
        {
			if (primer % segundo == 0)
            {
				Console.WriteLine("{0} es múltiplo de {1}. Dame otros números:", segundo, primer);
				primer = Convert.ToInt32(Console.ReadLine());
				segundo = Convert.ToInt32(Console.ReadLine());
			}
				else
				{
					if (segundo % primer == 0)
					{
						Console.WriteLine("{0} es múltiplo de {1}. Dame otros números:", primer, segundo);
						primer = Convert.ToInt32(Console.ReadLine());
						segundo = Convert.ToInt32(Console.ReadLine());
					}
						else
						{
							Console.WriteLine("Ningún número de los dos es múltiplo del otro");
							primer = Convert.ToInt32(Console.ReadLine());
							segundo = Convert.ToInt32(Console.ReadLine());
						}
				}

		}

		Console.WriteLine("No se puede calcular el múltiplo de 0");


	}
}
