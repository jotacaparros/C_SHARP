using System;

public class Ejercicio_1_11_2
{
	/* (1.11.2) Pedir al usuario un número y mostrar su tabla de multiplicar,
		usando {0},{1} y {2}. Por ejemplo, si el número es el 3, debería escribirse
		algo como:

			3 x 0 = 0
			3 x 1 = 3
			3 x 2 = 6
			…
			3 x 10 = 30 */

	public static void xxx(){

		// int num1, res0, res1, res2, res3, res4, res5, res6, res7, res8, res9, res10;

		Console.Write("INSERTA UN NÚMERO PARA SACAR SU TABLA DE MULTIPLICAR:");

		/* num1 = Convert.ToInt32(Console.ReadLine());

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

		Console.WriteLine("{0} * 0 = {1}", num1, res0);
		Console.WriteLine("{0} * 1 = {1}", num1, res1);
		Console.WriteLine("{0} * 2 = {1}", num1, res2);
		Console.WriteLine("{0} * 3 = {1}", num1, res3);
		Console.WriteLine("{0} * 4 = {1}", num1, res4);
		Console.WriteLine("{0} * 5 = {1}", num1, res5);
		Console.WriteLine("{0} * 6 = {1}", num1, res6);
		Console.WriteLine("{0} * 7 = {1}", num1, res7);
		Console.WriteLine("{0} * 8 = {1}", num1, res8);
		Console.WriteLine("{0} * 9 = {1}", num1, res9);
		Console.WriteLine("{0} * 10 = {1}", num1, res10);
		*/
		
		 int resultado, operacion, numero;
		
		numero = Convert.ToInt32(Console.ReadLine());

		operacion = 0;
		resultado = numero * operacion;
		Console.WriteLine("{0} * {1} = {2}", numero, operacion, resultado);

		operacion = 1;
		resultado = numero * operacion;
		Console.WriteLine("{0} * {1} = {2}", numero, operacion, resultado);

		operacion = 2;
		resultado = numero * operacion;
		Console.WriteLine("{0} * {1} = {2}", numero, operacion, resultado);

		 
	}
}
