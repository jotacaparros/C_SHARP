using System;

public class Ejercicio_2_2_3_5
{
	/*(2.2.3.5) Crea un programa que muestre los primeros ocho números pares: 2 4 6 8 
	10 12 14 16 (pista: en cada pasada habrá que aumentar de 2 en 2, o bien mostrar 
	el doble del valor que hace de contador).*/
	public static void xxxx()
	{
		int pares;

        for (pares = 1; pares <= 16; pares ++)
        {
			if (pares % 2 == 0)
            {
				Console.WriteLine(pares);
			}
			
        }
	}
}
