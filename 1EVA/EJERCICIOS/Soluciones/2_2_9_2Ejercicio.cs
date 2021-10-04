using System;

public class Ejercio_2_2_9_2
{
	/*2.2.9.2) Crea un programa que pida al usuario dos números y escriba sus 
	divisores comunes. Debes usar llaves en todas las estructuras de control, aunque 
	sólo incluyan una sentencia.
	*/
	public static void xxx()
	{
		int numA, numB, menor;

		Console.WriteLine("Número A:");

	numA = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Número B:");

	numB = Convert.ToInt32(Console.ReadLine());

	
		menor = (numA < numB) ? numA : numB;
		
		for (int i = menor; 0 < i ; i--)
        {
			if ((numA % i == 0) && (numB % i == 0))
			{
				Console.Write("{0} ", i);
			}
        }
	}
}
