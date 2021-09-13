using System;

public class Ejercicio_1_11_3
{
	/* (1.11.3) Crear una variante del programa anterior, que pide al usuario un
	número y muestra su tabla de multiplicar. Esta vez no deberás utilizar {0},
	{1}, {2}, sino "Write" */

	public static void xxxx(){

		int num1, res0, res1, res2, res3, res4, res5, res6, res7, res8, res9, res10;

		Console.Write("INSERTA UN NÚMERO PARA SACAR SU TABLA DE MULTIPLICAR:");

		num1 = Convert.ToInt32(Console.ReadLine());

		res0 = num1 * 0;
		res1 = num1 * 1;
		res2 = num1 * 2;
		res3 = num1 * 3;
		res4 = num1 * 4;
		res5 = num1 * 5;
		res6 = num1 * 6;
		res7 = num1 * 7;
		res8 = num1 * 8;
		res9 = num1 * 9;
		res10 = num1 * 10;

		Console.Write(num1 + " * 0 = " + res0 + ". ");
		Console.Write(num1 + " * 1 = " + res1 + ". ");
		Console.Write(num1 + " * 2 = " + res2 + ". ");
		Console.Write(num1 + " * 3 = " + res3 + ". ");
		Console.Write(num1 + " * 4 = " + res4 + ". ");
		Console.Write(num1 + " * 5 = " + res5 + ". ");
		Console.Write(num1 + " * 6 = " + res6 + ". ");
		Console.Write(num1 + " * 7 = " + res7 + ". ");
		Console.Write(num1 + " * 8 = " + res8 + ". ");
		Console.Write(num1 + " * 9 = " + res9 + ". ");
		Console.Write(num1 + " * 10 = " + res10 + ". ");


	}
}
