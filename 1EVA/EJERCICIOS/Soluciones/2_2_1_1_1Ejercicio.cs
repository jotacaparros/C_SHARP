using System;

public class Ejercicio_2_2_1_1_1
{
	/*(2.2.1.1.1) Crea un programa que pida al usuario su contraseña (numérica).
	Deberá terminar cuando introduzca como contraseña el número 1111, pero
	volvérsela a pedir tantas veces como sea necesario.*/
	
	public static void xxx()
	{
		int pasword;
		
		Console.WriteLine("Introduzca contraseña");

		pasword = Convert.ToInt32(Console.ReadLine());

		while (pasword != 1111)
        {
			Console.WriteLine("Contraseña incorrecta. Introduzca contraseña:");
			pasword = Convert.ToInt32(Console.ReadLine());

		}

		Console.WriteLine("Contraseña correcta");


	}
}
