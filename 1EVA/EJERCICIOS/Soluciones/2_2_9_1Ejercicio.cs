using System;

public class Ejercicio_2_2_9_1
{
	/*(2.2.9.1) Crea un programa que pida un número al usuario y escriba los múltiplos 
	de 9 que haya entre 1 ese número. Debes usar llaves en todas las estructuras de 
	control, aunque sólo incluyan una sentencia.*/
	public static void xxx()
	{
		int multiplo;

		for (int i = 1; i <= 9; i++)
        {
			multiplo = i * 9;
			Console.WriteLine(multiplo);
        }
	}
}
