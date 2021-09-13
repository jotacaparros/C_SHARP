using System;

public class Ejercicio_1_9_4
{
	/*(1.9.4) Pide al usuario una cantidad de "millas náuticas" y muestra 
	  la equivalencia en metros, usando: 1 milla náutica = 1852 metros. */

	public static void xxxX(){

		int num1, resu;

		Console.WriteLine("INSERTA UN NÚMERO DE MILLAS NAUTICAS Y PROCEDERÉ A CONVERTIRLAS EN METROS");

		num1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("MARINERO, EL RESULTADO ES:");

		resu = num1 * 1825;

		Console.WriteLine("{0} METROS", resu);




	}
}
