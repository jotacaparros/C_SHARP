using System;

public class Ejercicio_2_1_2_1
{
	/*(2.1.2.1) Crea un programa que pida al usuario un número entero. Si es múltiplo
	de 10, informará al usuario y pedirá un segundo número, para decir a
	continuación si este segundo número también es múltiplo de 10.*/
	public static void xx()
	{
		Console.WriteLine("Dame un número taaaan grande como el amor que sientes al abrazar a tus amigos en el aeropuerto");

			int numAmor, numAmor2;
			numAmor = Convert.ToInt32(Console.ReadLine());

		
		if(numAmor % 10 == 0) 
		{
			Console.Write("Guau amig@, eso es mucho amor. Seguro que tus amigos te aprecian un monton. Tu amor es múltiplo de 10.");
			Console.WriteLine("¡Tengo una idea! ¿Por qué no me dices cuanto amor sientes al abrazar a tus amigos, pero esta vez en una estación de tren? ");
			numAmor2 = Convert.ToInt32(Console.ReadLine());

			if(numAmor2 % 10 == 0) 
			{
				Console.WriteLine("Guaauu amig@ ¡No paras de sorprenderme!¡Tu amor vuelve a ser múltiplo de 10! Solo hay amor en tí");
			}
				else
				{
				Console.WriteLine("Por un momento pensé que eras especial, pero en realidad eres una persona horrible");
				}
		}
			else 
			{
			Console.WriteLine("Eres una persona horrible");
			}
	}
}
