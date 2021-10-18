using System;

public class Ejercicio_2_7_1
{
	/*(2.7.1) Crea un programa que pregunte al usuario su edad y su año de nacimiento. 
	Si la edad que introduce no es un número válido, mostrará un mensaje de aviso.
	Lo mismo ocurrirá si el año de nacimiento no es un número válido.*/
	
	public static void ErrorEdad()
	{
		byte edad;
		short ano;

        try
        {
			Console.WriteLine("¿Qué edad tienes marinero?");
			edad = Convert.ToByte(Console.ReadLine());

			Console.WriteLine("¿Y en qué año naciste?");
			ano = Convert.ToInt16(Console.ReadLine());
		}
			catch(FormatException)
			{
				Console.WriteLine("Error: introduzca un número");
			}
			
			catch(OverflowException)
			{
				Console.WriteLine("Error: introduzca una cifra válida");
			}

	}
}
