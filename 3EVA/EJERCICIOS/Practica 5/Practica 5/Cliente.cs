using System;

public class Cliente
{
	string nombre;
	string apellido;
	string provincia;
	public Cliente()
	{	

	}
	 public string GetNombre()
    {
		return nombre;
    }

	public string GetApellido()
	{
		return apellido;
	}

	public string GetProvincia()
	{
		return provincia;
	}

	public void SetNombre(string nom)
    {
		nombre = nom;
    }

	public void SetApellido(string ape)
	{
		apellido = ape;
	}

	public void SetProvincia(string pro)
	{
		provincia = pro;
	}
}
