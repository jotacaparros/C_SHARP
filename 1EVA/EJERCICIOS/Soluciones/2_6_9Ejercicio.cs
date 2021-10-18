using System;

public class Ejercicio_2_6_9
{
	public static void MuyGrande()
	{
		/*(2.6.9) Crea un programa que "dibuje" un cuadrado formado por cifras sucesivas, 
		con el tamaño que indique el usuario, hasta un máximo de 9. Por ejemplo, si desea 
		tamaño 5, el cuadrado sería así:
		11111
		22222
		33333
		44444
		55555 */

		Console.WriteLine("Del 1 al 9 ¿Cómo de grande lo quieres?");
		int num;
		num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
				Console.Write(i + 1);

            }
			Console.WriteLine();
        }

	}

		
}
