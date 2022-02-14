using System;

public class Inicio
{
	public static void Main()
	{
		Libro manuscrito1 = new Libro();

		manuscrito1.SetAutor("Midas Fachero");
		manuscrito1.SetTitulo("Cómo hacer un buen frances invertido y llegar al orgasmo");
		manuscrito1.SetPaginas(895);
		manuscrito1.SetUbicacion("Toledo");

        Console.WriteLine(manuscrito1.GetTitulo());
        Console.WriteLine(manuscrito1.GetAutor()); 
        Console.WriteLine(manuscrito1.GetPaginas());
        Console.WriteLine(manuscrito1.GetUbicacion()); 
		

	

	}
}
