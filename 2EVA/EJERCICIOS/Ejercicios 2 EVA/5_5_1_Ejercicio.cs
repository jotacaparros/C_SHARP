using System;

public class Ejercicio_5_5_1
{
	/*(5.5.1) Crea una función "PedirEntero", que reciba como parámetros el texto
	que se debe mostrar en pantalla, el valor mínimo aceptable y el valor máximo aceptable.
	Deberá pedir al usuario que introduzca el valor tantas veces como sea necesario,
	volvérselo a pedir en caso de error, y devolver un valor correcto. Pruébalo con
	un programa que pida al usuario un año entre 1800 y 2100.*/

	public static void xxx()
	{
		bool salir = true;
		do
		{
			Console.WriteLine("Adivina el número que quiero:");
			int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PedirEntero(numero));
			salir = Salir(numero);

		} while (salir!);

	}

	public static string PedirEntero(int x)
    {
		
		if (x < 1800 || x > 2100)
        {
			string fallaste = "Ese número me vale verga, prueba otra vez";
			return fallaste;
        }
        else
        {
			string acierto = "GRAAANDE MAKINON";
			return acierto; 
        }

    }

	public static bool Salir(int x)
    {
		if (x < 1800 || x > 2100)
		{
			bool noSale = true;
			return noSale;
		}
		else
		{
			bool siSale = false;
			return siSale;
		}

	}
}
