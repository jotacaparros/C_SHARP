using System;
/*(6.5.2) Amplía las clases del ejercicio 6.4.2, creando un nuevo proyecto con 
 * las siguientes características: 
		* La clase Persona no cambia; 
		* la clase PersonaInglesa se modificará para que redefina el método "Saludar", 
 			para que escriba en pantalla "Hi, I am " seguido de su nombre; 
		* se creará una nueva clase PersonaItaliana, en el fichero "personaItaliana.cs", 
			que deberá heredar las características de la clase "Persona", 
			pero redefinir el método "Saludar", para que escriba en pantalla "Ciao";
		* crea también una clase llamada PruebaPersona3, en el fichero " pruebaPersona3.cs",
			que deberá contener sólo la función Main y creará un objeto de tipo Persona, 
			dos de tipo PersonaInglesa, uno de tipo PersonaItaliana, les asignará un nombre,
			les pedirá que saluden y pedirá a la persona inglesa que tome té.
 */
public class Ejercicio_6_5_2
{
	public Ejercicio_6_5_2()
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
