using System;

public class Ejercicio_1_8_1
{
	// Quito el main para que en los siguientes ejer. no me de error de multip entrada
	public static void xxxx(string[] args){

		/* Antes lo tenia con int y cuando realizaba una opera. que diese decimale
		no me lo mostraba si las 2 variable no era float*/

		float metros;
		float millas;

		Console.WriteLine("¿Quieres saber cuantas millas son x metros? Dame un número de metros y dale a enter");

		metros = Convert.ToInt32(Console.ReadLine());

		millas = (metros/1609);

		Console.WriteLine("Efectiviwonder, {0} metros son {1} millas!", metros, millas);
	}
}
