using System;

public class Inicio
{
	public static void Main()
	{
		Persona person1 = new Persona();
		person1.SetNombre("Jonhy el sucio");

		PersonaInglesa personIng1 = new PersonaInglesa();
		personIng1.SetNombre("Waldo Waterparty");

		PersonaItaliana personIta1 = new PersonaItaliana();
		personIta1.SetNombre("Marco Gellato Spaguhettone");

		person1.Saludar();
		personIng1.Saludar();
		personIta1.Saludar();

	}
}
