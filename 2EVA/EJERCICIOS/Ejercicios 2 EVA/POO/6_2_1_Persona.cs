using System;

	/*(6.2.1) Crea una clase llamada Persona, en el fichero "persona.cs". 
		Esta clase deberá tener un atributo "nombre", de tipo string. 
		También deberá tener un método "SetNombre", de tipo void y con un parámetro string,
		que permita cambiar el valor del nombre. Finalmente, también tendrá un método "Saludar", 
		que escribirá en pantalla "Hola, soy " seguido de su nombre. Crea también una clase llamada PruebaPersona.
		Esta clase deberá contener sólo la función Main, que creará dos objetos de tipo Persona,
		les asignará un nombre a cada uno y les pedirá que saluden.*/

	public class PruebaPersona
	{
		public static void xxx(string[] args)
		{
			Persona person1 = new Persona();
			Persona person2 = new Persona();

			person1.SetNombre("Julio");
			person2.SetNombre("Pocahontas");

			person1.Saludar();
			person2.Saludar();
		}

	}

	public class Persona
	{
		string nombre;

		public void SetNombre(string name)
		{
			nombre = name;
		}
		public void Saludar()
		{
			Console.WriteLine("Hola, soy {0}", nombre);
		}
	}