using System;

public class Ejercicio_5_3_2
{
	/*(5.3.2) Crea una función "DibujarRectangulo" que dibuje en pantalla un rectángulo 
	del ancho y alto que se indiquen como parámetros. Incluye un Main para probarla.*/
	static int ancho, alto;
	static bool salir = false;
	public static void xxx()
	{
		do
		{
			Parametrea();
			DibujarRectangulo();
		} while (salir == false);
	}

	public static void Parametrea()
    {
		Console.WriteLine("¿De qué tamaño quieres el rectángulo campeón?");
        Console.Write("Dame el ancho:");
		ancho = Convert.ToInt32(Console.ReadLine());
		Console.Write("Dame el alto:");
		alto = Convert.ToInt32(Console.ReadLine());
		
	}
	
	public static void DibujarRectangulo()
    {
		if (alto != ancho)
        {
			for (int i = 0; i < alto; i++)
			{
				for (int j = 0; j < ancho; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			salir = true;
        }
        else
        {
            Console.WriteLine("El ancho y el alto no puede ser el mismo crack porque sino sería un cuadrado. Prueba otra vez máquina.\n");
		
        }
    }


}
