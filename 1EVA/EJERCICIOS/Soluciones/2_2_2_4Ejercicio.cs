using System;

public class Ejercicio_2_2_2_4
{
	/*(2.2.2.4) Crea un programa que pida al usuario su identificador y su contraseña
	(ambos numéricos), y no le permita seguir hasta que introduzca como
	identificador "1234" y como contraseña "1111"*/
	public static void xxxx()
	{
		int id, password;

		do
		{
			Console.WriteLine("Santo y seña:");
			id = Convert.ToInt32(Console.ReadLine());
			password = Convert.ToInt32(Console.ReadLine());

			if (id != 1234 || password != 1111)
			{
				Console.WriteLine("Escoria impostora! No vuelvas hasta que seas uno de los nuestros.");
			}
		}
		while (id != 1234 || password != 1111);

		Console.WriteLine("Bienvenido caballero!");
	}
}
