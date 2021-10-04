using System;

public class Ejercicio_2_2_10_2
{
	/*2.2.10.2) Crea un programa que pida al usuario dos números y escriba su mínimo 
	común múltiplo (pista: una solución lenta pero sencilla es probar con un "for" 
	todos los números a partir del mayor de ambos, de forma creciente; cuando 
	encuentres un número que sea múltiplo de ambos, interrumpes la búsqueda).*/
	
	public static void xxx()
	{
		int numA, numB, mayor;

		Console.WriteLine("Número A:");

		numA = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Número B:");

		numB = Convert.ToInt32(Console.ReadLine());

		mayor = (numA > numB) ? numA : numB;

		for (int i = mayor; 1 < mayor; i++)
        {
			if (( i % numA == 0) && ( i % numB == 0))
			{
				Console.WriteLine(i);
				break;
			}
        }

	}
}
