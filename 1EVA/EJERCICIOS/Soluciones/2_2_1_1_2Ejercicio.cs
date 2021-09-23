using System;

public class Ejercicio_2_2_1_1_2
{
	/*(2.2.1.1.2) Crea un "calculador de cuadrados": pedirá al usuario un número y
	mostrará su cuadrado. Se repetirá mientras el número introducido no sea cero
	(usa "while" para conseguirlo).*/

	public static void xxx()
	{
		int cuadrado;
		double cuadra2;
		
		Console.WriteLine("Dame un número y te daré su cuadrado");

		cuadrado = Convert.ToInt32(Console.ReadLine());

		while (cuadrado != 0)
        {
			cuadra2 = Math.Pow(cuadrado, 2);
			Console.WriteLine("El cuadrado de {0} es {1}. Dame otro número:", cuadrado, cuadra2);
			cuadrado = Convert.ToInt32(Console.ReadLine());

		}

		Console.WriteLine("No se puede calcular el cuadrado de 0");


	}
}
