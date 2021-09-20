using System;

public class Ejercicio_2_1_9_1
{
	/* Crea un programa que pida un número del 1 al 5 al usuario, y escriba el
	nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el
	programa escribirá "uno"). */
	public static void xxxx()
	{
		Console.WriteLine("Dame un número y te lo escribo");

		int num1;

	num1 = Convert.ToInt32(Console.ReadLine());

		switch (num1)
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


		}
	}
}
