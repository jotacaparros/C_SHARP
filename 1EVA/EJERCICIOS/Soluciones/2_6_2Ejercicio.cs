using System;

public class Ejercicio_2_6_2
{
	/*(2.6.2) Crear un programa que descomponga un número (que teclee el usuario) 
	como producto de su factores primos. Por ejemplo, 60 = 2 · 2 · 3 · 5*/
	
	public static void Main()
	{
		int numero = Convert.ToInt32(Console.ReadLine());

		for (int i = 2; i <= numero; i++)
        {
			if (numero % i == 0)
            {
				Console.Write(i);
				if (numero != i) Console.Write(" · ");
                {
					numero = numero / i; // numero/=1;
					i--;
                }

            }
        }
	}
}
