using System;

public class Ejercicio_2_7_2
{
	/*(2.7.2) Crea un programa que pregunte al usuario su edad y su año de nacimiento. 
	Si la edad que introduce no es un número válido, mostrará un mensaje de aviso, 
	pero aun así le preguntará su año de nacimiento.*/

	public static void Pregunton()
	{

		byte edad;
		short ano;

		try
		{
			Console.WriteLine("¿Qué edad tienes marinero?");
			edad = Convert.ToByte(Console.ReadLine());
		}
		catch (FormatException)
		{
			Console.WriteLine("Error: introduzca un número");
		}

		catch (OverflowException)
		{
			Console.WriteLine("Error: introduzca una cifra válida");
		}

		try
		{
			Console.WriteLine("¿Y en qué año naciste?");
			ano = Convert.ToInt16(Console.ReadLine());
		}
		catch (FormatException)
		{
			Console.WriteLine("Error: introduzca un número");
		}

		catch (OverflowException)
		{
			Console.WriteLine("Error: introduzca una cifra válida");
		}
	}
}
