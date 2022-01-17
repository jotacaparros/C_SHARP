using System;

public class Ejercicio_5_3_3
{
	/*(5.3.3) Crea una función "DibujarRectanguloHueco" que dibuje en pantalla un rectángulo hueco del ancho y alto que se indiquen como parámetros,
	 formado por una letra que también se indique como parámetro. Completa el programa con un Main que pida esos datos al usuario y dibuje el rectángulo. */
	public static void xxx()
	{
		int ancho = 0;
		int largo = 0;

        Console.Write("Introduce el ancho de tu rectángulo:");
		ancho = Convert.ToInt32(Console.ReadLine());

		Console.Write("Introduce el largo de tu rectángulo:");
		largo = Convert.ToInt32(Console.ReadLine());

		DibujarRectanguloHueco(ref largo, ref ancho);
	}

	public static void DibujarRectanguloHueco(ref int largo,ref int ancho)
    {
		for(int i = 0; i < largo; i++)
        {
			for (int j = 0; j < ancho; j++)
			{
				if (i == 0 || i == largo - 1 || j == 0 || j == ancho - 1)
				{
					Console.Write('*');
				}
				else
				{
					Console.Write(' ');
				}
				
			}
            Console.WriteLine();
        }
    }
}
