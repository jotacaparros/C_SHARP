using System;

public class Ejercicio2_1_3_1
{
	/*(2.1.3.1) Crea un programa que multiplique dos números enteros de la siguiente
	forma: pedirá al usuario un primer número entero.Si el número que se que teclee
	es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". Si se ha
	tecleado un número distinto de cero, se pedirá al usuario un segundo número y se
	mostrará el producto de ambos*/

	public static void xxx()
	{
		int num1, num2, resultado;

		Console.WriteLine("2 números para multiplicar");
		
		num1 = Convert.ToInt32(Console.ReadLine());	
		if (num1 == 0)
        {
			Console.WriteLine("El producto de 0 por cualquier número es 0, paleto");
        }
        else {
			num2 = Convert.ToInt32(Console.ReadLine());
			if (num2 == 0)
			{
				Console.WriteLine("El producto de 0 por cualquier número es 0, paleto");
			}
				else
				{
				resultado = num1 * num2;
				Console.WriteLine("El resultado es {0}", resultado);
				}
		}
		
	}
}
