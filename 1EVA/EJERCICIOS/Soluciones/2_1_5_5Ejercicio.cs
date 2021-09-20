using System;

public class Ejercicio_2_1_5_5
{
	/*(2.1.5.5) Crea un programa que pida al usuario dos números enteros y diga si
	ambos son pares.*/

	public static void xxx()
	{
		int num1 = 0, num2 = 0;

		Console.WriteLine("Dame 2 números");

		num1 = Convert.ToInt32(Console.ReadLine());
		num2 = Convert.ToInt32(Console.ReadLine());

		if ( num1 % 2 == 0 && num2 % 2 == 0)
        {
			Console.WriteLine("Tus 2 números son pares");
		}
			else
			{
				if (num1 % 2 != 0 && num2 % 2 != 0)
				{
				Console.WriteLine("Tus 2 números son impares");
				}
					else
					{
						if (num1 % 2 == 0 && num2 % 2 != 0)
						{
						Console.WriteLine("Tu primer número es par y tu segundo es impar");
						}
							else
							{
								if (num1 % 2 != 0 && num2 % 2 == 0)
								{
									Console.WriteLine("Tu primer número es impar y tu segundo es par");
								}
							}
					}
			}

	}
}
