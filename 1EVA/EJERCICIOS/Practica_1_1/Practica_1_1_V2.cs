using System;

public class Practica_1_1_V2
{
	public static void Main()
	{
		int numero = 0;
		char opera;
		bool condicion = true;
		do
		{
			do
			{
				try
				{
					numero = Convert.ToInt32(Console.ReadLine());
					condicion = false;
				}	
					catch(Exception)
					{
						condicion = true;
					}

			} while (condicion == true);

			do
			{
				opera = Convert.ToChar(Console.ReadLine());

				switch (opera)
				{
					case '+':
						numero += numero;
						break;
					case '-':
						numero -= numero;
						break;
					case '*':
						numero *= numero;
						break;
					case '/':
						if (numero != 0)
						{
							numero /= numero;
						}
						else
						{
							Console.WriteLine("No se puede dividir un número entre 0");
						}
						break;
					default:
				}

			} while (opera != 's' || opera != '=');

        } while(opera != 's');

	}
}
