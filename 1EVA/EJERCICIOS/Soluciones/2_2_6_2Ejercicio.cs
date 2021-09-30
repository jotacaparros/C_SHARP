using System;

public class Ejercicio_2_2_6_2
{
	/*2.2.6.2) Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto 
	(por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos:
	****
	****
	*****/
	public static void xxx()
	{
		int anch, alto;

		Console.WriteLine("Dame una cifra para la anchura");
		anch = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Dame una cifra para la altura");
		alto = Convert.ToInt32(Console.ReadLine());

		for(int j = 0; j < alto; j++)
        {
			for (int i = 0; i < anch; i++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
        }
	}
}
