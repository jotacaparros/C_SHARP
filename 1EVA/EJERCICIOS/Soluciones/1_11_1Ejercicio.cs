using System;

public class Ejercicio_1_11_1
{
	/* (1.11.1) El usuario tecleará dos números (a y b), y el programa mostrará el
	resultado de la operación (a+b)*(a-b) y el resultado de la operación a^2-b^2.
	Ambos resultados se deben mostrar en la misma línea. */

	public static void xxxx(){

		int num1, num2, resu1, resu2;

		Console.Write("INSERTA UN NÚMERO:");

		num1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("AHORA DAME OTRO ¡RÁPIDO!:");

		num2 = Convert.ToInt32(Console.ReadLine());

		resu1 = (num1 + num2) * (num1 - num2);
		resu2 = num1 ^ 2 - num2 ^ 2;

		Console.Write("ESTO {0} Y ESTO {1} ES LO QUE BUSCAS ¿VERDAD?!!!", resu1, resu2);


	}
}
