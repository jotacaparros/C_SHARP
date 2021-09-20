using System;

public class Ejercicio_2_1_8_1
{
	/*(2.1.8.1) Crea un programa que use el operador condicional para mostrar un el
	valor absoluto de un número de la siguiente forma: si el número es positivo, se
	mostrará tal cual; si es negativo, se mostrará cambiado de signo.*/
	
	public static void xxxx()
	{
		Console.WriteLine("Echame un número a la cara. Puede ser positivo o negativo");

		int num1 = 0, resultado;

		num1 = Convert.ToInt32(Console.ReadLine());

		resultado = num1 > 0 ? num1 : num1 * -1;

		Console.WriteLine("El resultado es {0}", resultado);
	}
}
