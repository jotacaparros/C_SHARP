using System;

public class Ejercicio_2_2_7_2
{
	/*2.2.7.2) Crea un programa que muestre 5 veces las letras de la L (mayúscula) a la 
	N (mayúscula), en la misma línea.*/

	public static void xxx()
	{
		char Letrita;

		for (int i = 0; i < 5; i++)
		{
			for( Letrita = 'L'; Letrita <= 'N'; Letrita++)
            {
				Console.Write(Letrita);
            }
			Console.WriteLine();
		}
	}
}
