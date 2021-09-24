using System;

public class Ejercicio_2_2_1_2_3
{

	/*(2.2.1.2.3) Crea un programa calcule cuantas cifras tiene un número entero
	positivo (pista: se puede hacer dividiendo varias veces entre 10).*/
	public static void xxxx()
	{
		int num = Convert.ToInt32(Console.ReadLine());
		int contador = 1;
		
		while (num > 10)
        {
			num = num / 10;
			contador++;	
        }

		Console.WriteLine(contador);

	}
}
