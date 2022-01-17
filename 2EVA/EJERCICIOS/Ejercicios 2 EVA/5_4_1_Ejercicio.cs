using System;

public class Ejercicio_5_4_1
{
	/*(5.4.1) Crea una función "Cubo" que calcule el cubo de un número real (float) que se indique como parámetro. 
	El resultado deberá ser otro número real. Prueba esta función para calcular el cubo de 3.2 y el de 5. */
	
	static float resultado; 
	public static void xxx()
	{
        Console.WriteLine("Introduce un número que quieras saber su cubo.");
		float numero = float.Parse(Console.ReadLine());
		Cubo(ref numero);
        Console.WriteLine(resultado);
	}

	public static float Cubo(ref float numero)
    {
		resultado = numero * numero * numero;
		return resultado;
    }
}
