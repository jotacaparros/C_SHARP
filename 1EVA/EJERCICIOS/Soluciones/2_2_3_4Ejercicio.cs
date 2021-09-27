using System;

public class Ejercicio_2_2_3_4
{
	/*(2.2.3.4) Crea un programa que muestre la tabla de multiplicar del 9.*/
	public static void xxx()
	{
		int multiplica, resultado;

        for (multiplica = 0; multiplica <= 10; multiplica++)
        {
			resultado = multiplica * 9;
			Console.WriteLine("9 x {0} = {1}", multiplica, resultado);
        }
	}
}
