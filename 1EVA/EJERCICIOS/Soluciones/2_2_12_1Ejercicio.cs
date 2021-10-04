using System;

public class Ejercicio_2_2_12_1
{
	/*2.2.12.1) Crea un programa que escriba los números del 100 al 200, separados 
	por un espacio, sin avanzar de línea, usando "for". En la siguiente línea, vuelve a 
	escribirlos usando "while".*/
	
	public static void bitchh()
	{
		
        for (int i = 100; i < 201; i++)
        {
			Console.Write("{0} ", i);
        }
		
		Console.WriteLine();
		int j = 99;
		
		while (j != 200)
        {
			j++;
			Console.Write("{0} ", j);
		}


	}
}
