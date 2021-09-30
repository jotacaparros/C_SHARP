using System;

public class Ejercicio_2_2_8_1
{
	/*(2.2.8.1) Crea un programa que escriba 6 líneas de texto, cada una de las cuales 
	estará formada por los números del 1 al 7. Debes usar dos variables llamadas 
	"linea" y "numero", y ambas deben estar declaradas en el "for".*/
	
	public static void xxx()
	{
		for(int linea = 0; linea < 6; linea++)
        {
			for(int numeros = 1; numeros <= 7; numeros++)
            {
				Console.Write(numeros);
            }
			Console.WriteLine();
        }
	}
}
