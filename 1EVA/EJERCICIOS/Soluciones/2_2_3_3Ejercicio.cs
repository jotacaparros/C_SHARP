using System;

public class Ejercicio_2_2_3_3
{ 
	/*(2.2.3.1.3) Crea un programa que muestre los números del 100 al 200 (ambos 
	incluidos) que sean divisibles entre 7 y a la vez entre 3.*/

	public static void xxx()
	{
	int contador;

		for (contador=100; contador<=200; contador++)
        {
			if (contador % 7 == 0 || contador % 3 ==0 )
            {
				Console.WriteLine(contador);
            }
        }
	}
}
