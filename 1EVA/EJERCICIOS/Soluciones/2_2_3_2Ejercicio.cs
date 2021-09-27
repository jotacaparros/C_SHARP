using System;

public class Ejercicio_2_2_3_2
{
	/*(2.2.3.2) Crea un programa que escriba en pantalla los números del 1 al 50 que 
	sean múltiplos de 3 (pista: habrá que recorrer todos esos números y ver si el resto 
	de la división entre 3 resulta 0).*/
	public static void xxx()
	{
		int numer;

		for(numer= 1; numer<= 50; numer++)
        {
			if (numer % 3 == 0)
            {
				Console.WriteLine(numer);
            }
        }
	}
}
