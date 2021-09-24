using System;

public class Ejercicio_2_2_2_5
{
	/*(2.2.2.5) Crea un programa que pida al usuario su identificador y su contraseña, y
	no le permita seguir hasta que introduzca como nombre "Pedro" y como
	contraseña "Peter".*/
	public static void xxx()
	{
		string id, password;

		do
		{
			Console.WriteLine("Santo y seña:");
			id = Convert.ToString(Console.ReadLine());
			password = Convert.ToString(Console.ReadLine());

			if (id != "Pepe" || password != "Peter")
			{
				Console.WriteLine("Escoria impostora! No vuelvas hasta que seas uno de los nuestros.");
			}
		}
		while (id != "Pepe" || password != "Peter");

		Console.WriteLine("Bienvenido caballero!");
	}
}
