using System;

public class prueba_array_stirng
{
	public static void xxx()
	{
		string original = "Hola Adios Pepe Pablo";
		string[] split = original.Split(' ');
		int numero = split.Length;

		string[] conjunto = new string[numero];
		int inicio = 0;
		int caracteres, fin;

		//Console.WriteLine(original.IndexOf(' '));

		for (int i = 0; i < numero; i++)
        {
           
			fin = original.IndexOf(' ', inicio);
			if(fin == -1)
            {
				fin = original.Length;
            }
			caracteres = fin - inicio;
			conjunto[i] = original.Substring(inicio, caracteres);

			inicio = fin + 1;
			
			Console.WriteLine(conjunto[i]);
		}

        
		/*tiene que aparecer
		 * string[] conjunto = new string[3];
		 * conjunto [0] = "Hola";
		 * conjunto [1] = "Adios";
		 * conjunto [2} = "Pepe";
		 * */

		/*int numero = original.Split(' ').Length;*/

		/*IndexOf/ .Substring */


	}
}
