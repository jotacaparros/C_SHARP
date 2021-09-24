using System;

public class Ejercicio_2_2_2_1_1
{
	/*(2.2.2.1) Crear un programa que pida números positivos al usuario, y vaya
	calculando y mostrando la suma de todos ellos (terminará cuando se teclea un
	número negativo o cero).*/
	public static void xxxx()
	{
		int num = Convert.ToInt32(Console.ReadLine()), suma = 0;

		do
		{
			suma = suma + num;
			Console.WriteLine(suma);
			num = Convert.ToInt32(Console.ReadLine());
		}
			while (num > 0);

		Console.WriteLine("No se pudo crack");
	}
}
