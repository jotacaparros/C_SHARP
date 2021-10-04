using System;

public class Ejercicio_2_2_10_1
{
	/*(2.2.10.1) Crea un programa que pida al usuario dos números y escriba su máximo 
	común divisor (pista: una solución lenta pero sencilla es probar con un "for" todos 
	los números descendiendo a partir del menor de ambos, hasta llegar a 1; cuando 
	encuentres un número que sea divisor de ambos, interrumpes la búsqueda).*/

	public static void xxxx()
	{
		int numA, numB, menor;

		Console.WriteLine("Número A:");

		numA = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Número B:");

		numB = Convert.ToInt32(Console.ReadLine());

		menor = (numA < numB) ? numA : numB;

		for (int i = menor; 1 < menor; i--)
        {
			if ((numA % i == 0) && (numB % i == 0))
            {
				Console.WriteLine(i);
				break;
            }
        }
	}
}
