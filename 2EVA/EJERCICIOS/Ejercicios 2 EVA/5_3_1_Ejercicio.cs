using System;

public class Ejercicio_5_3_1
{
	/*(5.3.1) Crea una función "DibujarCuadrado" que dibuje en pantalla un cuadrado 
	del ancho (y alto) que se indique como parámetro. Completa el programa con un 
	Main que permita probarla.*/
	static int ancho, alto;
	public static void xxx()
	{
		Parametrea();
		DibujarCuadrado();
	}

	public static void Parametrea()
    {
		Console.WriteLine("¿De qué tamaño quieres el cuadrado campeón?");
        Console.Write("Dame el ancho:");
		ancho = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dame el alto:");
		alto = Convert.ToInt32(Console.ReadLine());
		
	}
	
	public static void DibujarCuadrado()
    {
		for (int i = 0; i < alto; i++)
        {
			for (int j = 0; j < ancho; j++)
            {
				Console.Write("*");
            }
			Console.WriteLine();
        }
    }


}
