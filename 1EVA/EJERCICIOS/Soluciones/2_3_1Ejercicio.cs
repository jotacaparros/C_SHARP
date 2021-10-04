using System;

public class Ejercicio_2_3_1
{
	/*(2.3.1) Crea un programa que escriba los números del 1 al 10, separados por un 
	espacio, sin avanzar de línea. No puedes usar "for", ni "while", ni "do..while", sólo 
	"if" y "goto".*/

	public static void doubleTrouble()
	{
		int i = 0;
		
		contador:
		if(i != 10)
        {
			i++;
			Console.Write("{0} ", i);
			goto contador;
		}
	}
}
