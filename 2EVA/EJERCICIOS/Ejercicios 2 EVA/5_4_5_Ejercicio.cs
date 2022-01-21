using System;

public class Ejercicio_5_4_5
{
	/*(5.4.5) Crea una función "UltimaLetra", que devuelva la última letra de una cadena de texto.
	 * Prueba esta función para calcular la última letra de la frase "Hola".*/
	public static void xxx()
	{
        Console.WriteLine("Mete chicha chacho");
		string prueba = Console.ReadLine();
        Console.WriteLine(UltimaLetra(prueba));

	}

	public static char UltimaLetra(string i)
    {
		int posicion = i.Length -1;
		char letra = i[posicion];
		return letra;
    }
}
