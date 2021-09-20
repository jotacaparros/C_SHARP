using System;

public class Ejercicio_2_1_9_4
{
	/* Crea un programa que pida un número del 1 al 5 al usuario, y escriba el
	nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el
	programa escribirá "uno"). 
	
	 (2.1.9.4) Repite el ejercicio 2.1.9.1, empleando "if" en lugar de "switch"*/
	public static void xxxx()
	{
		Console.WriteLine("Dame un número y te lo escribo");

		int num1;

		num1 = Convert.ToInt32(Console.ReadLine());

		if (num1 == 1)
        {
			Console.WriteLine("Uno");
		}
			else
			{
				if (num1 == 2)
				{
					Console.WriteLine("Dos");
				}
					else
					{
						if (num1 == 3)
						{
							Console.WriteLine("Tres");
						}
							else
							{
								if (num1 == 4)
								{
									Console.WriteLine("Cuatro");
								}
									else
									{
										if (num1 == 5)
										{
											Console.WriteLine("Cinco");
										}
									}
				}
			}
		}

		/*switch (num1)
        {
			case 1: Console.WriteLine("Uno");
				break;
			case 2:Console.WriteLine("Dos");
				break;
			case 3:
				Console.WriteLine("tres");
				break;
			case 4:
				Console.WriteLine("Cuatro");
				break;
			case 5:
				Console.WriteLine("Cinco");
				break;
			default:
				Console.WriteLine("Número muy grande");
				break;


		}*/
	}
}
