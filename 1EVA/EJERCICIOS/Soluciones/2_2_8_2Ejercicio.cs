using System;

public class Ejercicio_2_2_8_2
{
	/*(2.2.8.2) Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto 
	(por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos, 
	como en el ejercicio 2.2.6.2. Deberás usar las variables "ancho" y "alto" para los 
	datos que pidas al usuario, y las variables "filaActual" y "columnaActual" 
	(declaradas en el "for") para el bloque repetitivo.*/

	public static void XXX()
	{
		int ancho, alto;

		Console.WriteLine("ALTURA CAPULLO!!!!!");
		alto = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("HE VISTO MIERDAS MÁS ALTAS QUE TÚ. DAME TU ANCHO SOLDADO!!!!!");
		ancho = Convert.ToInt32(Console.ReadLine());
		
		for (int filaActual = 0; filaActual < alto; filaActual++)
		{
			for (int columnaActual = 0; columnaActual < ancho; columnaActual++)
            {
				Console.Write("*");
            }
			Console.WriteLine();
        }
	}
}
