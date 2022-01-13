using System;

public class Ejercicio_5_2_3
{
	/*(5.2.3) Descompón en funciones la base de datos de ficheros (ejemplo 04_06a), de 
	modo que el "Main" sea breve y más legible (Pista: las variables que se compartan 
	entre varias funciones deberán estar fuera de todas ellas, y deberán estar 
	precedidas por la palabra "static").*/

	struct tipoFicha
	{
		public string nombreFich;
		public long tamanyo;
	}
	static int opcion;
	static tipoFicha[] fichas = new tipoFicha[1000];
	static int numeroFichas = 0;
	static int i;
	static string textoBuscar;
	static long tamanyoBuscar;

	public static void xxx()
	{
		do
		{
			MenuPrincipal();
			HazAlgo();
		} while (opcion != 5);

	}

	public static int MenuPrincipal()
	{
		Console.WriteLine();
		Console.WriteLine("Escoja una opción:");
		Console.WriteLine("1.- Añadir datos de un nuevo fichero");
		Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
		Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
		Console.WriteLine("4.- Ver datos de un fichero");
		Console.WriteLine("5.- Salir");
		opcion = Convert.ToInt32(Console.ReadLine());

		return opcion;
	}
	public static void HazAlgo()
    {
		switch (opcion)
		{
			case 1: // Añadir un dato nuevo
				if (numeroFichas < 1000)
				{ // Si queda hueco
					Console.WriteLine("Introduce el nombre del fichero: ");
					fichas[numeroFichas].nombreFich = Console.ReadLine();
					Console.WriteLine("Introduce el tamaño en KB: ");
					fichas[numeroFichas].tamanyo = Convert.ToInt32(Console.ReadLine());
					// Y ya tenemos una ficha más
					numeroFichas++;
				}
				else // Si no hay hueco para más fichas, avisamos
					Console.WriteLine("Máximo de fichas alcanzado (1000)!");
				break;

			case 2: // Mostrar todos
				for (i = 0; i < numeroFichas; i++)
					Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",fichas[i].nombreFich, fichas[i].tamanyo);
				break;

			case 3: // Mostrar según el tamaño
				Console.WriteLine("¿A partir de que tamaño quieres ver?");
				tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
				for (i = 0; i < numeroFichas; i++)
					if (fichas[i].tamanyo >= tamanyoBuscar)
						Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",fichas[i].nombreFich, fichas[i].tamanyo);
				break;

			case 4: // Ver todos los datos (pocos) de un fichero
				Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
				textoBuscar = Console.ReadLine();
				for (i = 0; i < numeroFichas; i++)
					if (fichas[i].nombreFich == textoBuscar)
						Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
						fichas[i].nombreFich, fichas[i].tamanyo);
				break;

			case 5: // Salir: avisamos de que salimos */
				Console.WriteLine("Fin del programa");
				break;

			default: // Otra opcion: no válida
				Console.WriteLine("Opción desconocida!");
				break;
		}
	}
}
