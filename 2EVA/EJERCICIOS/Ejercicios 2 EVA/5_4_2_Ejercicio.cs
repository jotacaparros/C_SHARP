using System;

public class Ejercicio_5_4_2
{
	/*(5.4.2) Crea una función "Menor" que calcule el menor de dos números enteros que recibirá como parámetros. El resultado será otro número entero.*/
	
	public static void Main()
	{
		int parametro1, parametro2;
        Console.WriteLine("Dame dos números y te digo cúal es el menor.");

		parametro1 = Convert.ToInt32(Console.ReadLine());
		parametro2 = Convert.ToInt32(Console.ReadLine());

		Menor(ref parametro1, ref parametro2);
	}

	public static int Menor(int x, int y)
    {
		if (parametro1 > parametro2)
        {
			return y;
        }else
        {
			return x;
        }
    }
}
