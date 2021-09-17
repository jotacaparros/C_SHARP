using System;

 public class Ejercicio_2_1_3_2
{
	/*(2.1.3.2) Crea un programa que pida al usuario dos números enteros.Si el
	segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo.
	Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir
	entre cero".*/

	public static void xx()
	{
		int num1, num2, resultado;

		Console.WriteLine("2 números para dividir");

		num1 = Convert.ToInt32(Console.ReadLine());
		num2 = Convert.ToInt32(Console.ReadLine());
		
		if (num2 == 0)
		{
			Console.WriteLine("Error: No se puede dividir entre cero");
		}
			else
			{
			resultado = num1 / num2;
			Console.WriteLine("El resultado es {0}", resultado);
		}

	}
}
