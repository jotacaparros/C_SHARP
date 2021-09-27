using System;

public class Ejercicio_2_2_5_3

	/*(2.2.5.3) Crea un programa que, para los números entre el 10 y el 20 (ambos 
	incluidos) diga si son divisibles entre 5, si son divisibles entre 6 y si son divisibles 
	entre 7.*/
{
	public static void xxx()
	{
        for (int num = 10; num < 21; num++)
        {
            for (int jum = 5; jum <=7 ; jum++)
            {
				if ( num % jum == 0)
                {
					Console.WriteLine("{0} es divisible entre {1}", num, jum);
                }

            }
		}
	}
}
