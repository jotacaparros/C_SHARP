using System;

public class Ejercicio_2_6_3

	/*(2.6.3) Crea un programa que calcule un número elevado a otro, usando 
	multiplicaciones sucesivas*/
{
	public static void MultiplicatePorCero()
	{
		Console.WriteLine("Dame 2 números y elevaré el primero por el segundo");
		int num, eleva, contador;

		num = Convert.ToInt32(Console.ReadLine());
		eleva = Convert.ToInt32(Console.ReadLine());
		contador = num;

		for (int i = 1; i<eleva; i++)
        {
			contador = contador * num;
			if (i == eleva - 1)
			{
				Console.Write(contador);
			}
		}

		
	}
}
