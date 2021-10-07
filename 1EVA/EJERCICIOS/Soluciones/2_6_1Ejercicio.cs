using System;

public class Ejercicio_2_6_1

	/*(2.6.1) Crear un programa que dé al usuario la oportunidad de adivinar un número 
	del 1 al 100 (prefijado en el programa) en un máximo de 6 intentos. En cada 
	pasada deberá avisar de si se ha pasado o se ha quedado corto.*/
{
	public static void Pervertido()
	{
		int  numero, contador = 0;

		Console.WriteLine("Solo un verdadero adivino sabe cuantas denuncias por acoso sexual tiene en proceso judicial Charlie el payaso pervertido. ");
		Console.WriteLine("Pista: No más de 100.");
		Console.WriteLine("¡OJO! Si en 6 intentos no aciertas, procederemos a soltarlo de su arresto provisional.");

		for (int i = 1; i < 7; i++)
		{
			numero = Convert.ToInt32(Console.ReadLine());

			if (numero == 32)
            {
				Console.WriteLine("¡Enhorabuena! Efectivamente eran 32, gracias a ti ese pervertido no verá la luz del sol en mucho tiempo.");
				i = 7;
            }
				else
				{
				Console.WriteLine("¡ERROR! Cuidado llevas {0} intentos", i);
				}
			contador++;
        }


		if (contador == 6)
		{
			Console.WriteLine("¡OH DIOS MIO! ¡¡¡POR TU CULPA HAN SOLTADO A ESE DEGENERADO!!!");
		}

	}
}
