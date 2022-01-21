using System;

public class Ejercicio_5_4_6
{  
	/*(5.4.6) Crea una función "MostrarPerimSuperfCuadrado" que reciba un número entero y calcule y muestre en pantalla 
    el valor del perímetro y de la superficie de un cuadrado que tenga como lado el número que se ha indicado como parámetro.*/

	public static void xxx()
	{
		Console.WriteLine("Necesito datos. DATOS NUMERÓTICOS");
		int dato = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MostrarPerimSuperfCuadrado(dato)); 
	}

	public static string MostrarPerimSuperfCuadrado(int x)
    {

		int perimetro = x * 4;
		int area = x * x;

        string mostrar = "Perimetro: " + perimetro + " Área: " + area;
		return mostrar;
    }
	
}
