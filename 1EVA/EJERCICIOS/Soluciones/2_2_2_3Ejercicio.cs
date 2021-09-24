using System;

public class Ejercicio_2_2_2_3
{
	/*(2.2.2.3) Crea un programa que escriba en pantalla los números pares del 26 al 10
	(descendiendo), usando "do..while".*/
	public static void xxxx()
	{
		int num = 26;
		Console.WriteLine(num);
		do
		{
			num = num - 2;
			Console.WriteLine(num);
		}
		while (num > 10);
	}
}
