﻿using System;

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
