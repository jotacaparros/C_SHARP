using System;

public class Ejercicio_5_2_2
{
	/*(5.2.2) Crea una función llamada "DibujarCuadrado3x3", que dibuje un cuadrado 
	formato por 3 filas con 3 asteriscos cada una. Incluye un "Main" para probarla.*/
	public static void xxx()
	{
		DibujarCuadrado3x3();
	}

	public static void DibujarCuadrado3x3()
    {
		for (int i = 0; i<= 2; i++)
        {
			for (int j = 0; j<=2; j++)
            {
				Console.Write("*");
            }
			Console.WriteLine();
		}
	}
}
