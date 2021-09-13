using System;

public class Ejercicio_1_9_2
{
	/*(1.9.2) Crea un programa que calcule la división de dos números introducidos por
	el usuario, así como el resto de esa división */

	public static void XX(){

		int num1, num2, resu;

		Console.WriteLine("INSERTE DOS NÚMEROS DE PLACER PARA CONSUMAR ACTO SEPARATISTA");

		Console.WriteLine("PRIMER NÚMERO:");

		num1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("OH SÍ CUANTO PLACER! INTRODUCE SEGUNDO NÚMERO:");

		num2 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("SOBRECARGA DE PLACER -.-.-.-.-. RESULTADO SEPARATISTA PLACENTERO:");

		resu = num1 / num2;

		Console.WriteLine(resu);




	}
}
