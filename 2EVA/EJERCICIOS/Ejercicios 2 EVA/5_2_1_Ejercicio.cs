using System;

public class Ejercicio_5_2_1
{
	/*(5.2.1) Crea una función llamada "BorrarPantalla", que borre la pantalla dibujando 
	25 líneas en blanco.Crea también un "Main" que permita probarla*/
	public static void xxx()
	{
		BorrarPantalla();
	}

	public static void BorrarPantalla()
    {
		for (int i = 0; i<= 100; i++)
        {
			Console.WriteLine("				");
		}
	}
}
