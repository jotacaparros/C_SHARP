using System;

public class Ejercicio_5_4_4
{
	/*(5.4.4) Crea una función "Inicial", que devuelva la primera letra de una cadena de texto.
	 * Prueba esta función para calcular la primera letra de la frase "Hola".*/
	public static void xxx()
	{
        Console.WriteLine("Escribe una frase y te doy la inicial caballero:");
		string frase = Console.ReadLine();
        Console.WriteLine(Inicial(frase));
	}

	public static char Inicial(string x)
    {
		char letraInicial = x[0];
		return letraInicial;
    }
}