using System;

public class Ejercicio_2_1_5_1
{
	/*(2.1.5.1) Crea un programa que pida al usuario un número entero y 
	responda si es múltiplo de 2 o de 3. */

	public static void XXX()
	{
		int num1 = 0;

		Console.WriteLine("Dame un número");

		num1 = Convert.ToInt32(Console.ReadLine());

		if (num1 % 2 != 0 && num1 % 3 != 0)
		{
			Console.WriteLine("Tu número no es múltiplo de 2 ni de 3");
		}
			else
			{
				if (num1 % 2 == 0 && num1 % 3 == 0)
				{
				Console.WriteLine("Tu número es múltiplo de 2 y de 3");
				}

					else
					{
						if (num1 % 3 == 0)
						{
						Console.WriteLine("Tu número es múltiplo de 3");
						}
							else
							{
								if (num1 % 2 == 0)
								{
								Console.WriteLine("Tu número es múltiplo de 2");
								}
							}
					}
			}
	}
}
