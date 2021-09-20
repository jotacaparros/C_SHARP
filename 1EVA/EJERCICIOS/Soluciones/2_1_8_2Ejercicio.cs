using System;

public class Ejercicio_2_1_8_2
{
	/*(2.1.8.2) Usa el operador condicional para calcular el menor de dos números */

	public static void xxx()
	{
		Console.WriteLine("Dame dos números y te digo cual es el mayor");
		int num1, num2, resultado;

		num1 = Convert.ToInt32(Console.ReadLine());
		num2 = Convert.ToInt32(Console.ReadLine());

		resultado = num1 > num2 ? num1 : num2;

		Console.WriteLine("{0} es mayor", resultado);
	}
}
