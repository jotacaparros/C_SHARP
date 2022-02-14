﻿using System;

public class PortonPrueba: Puerta
{
	bool bloqueada; 
	public void Bloquear() 
	{
		bloqueada = true; 
	}
	public void Desbloquear() 
	{ 
		bloqueada = false; 
	}
	public new void MostrarEstado() 
	{ 
		Console.WriteLine("Portón.");
		Console.WriteLine("Bloqueada: {0}", bloqueada);
	}
}
