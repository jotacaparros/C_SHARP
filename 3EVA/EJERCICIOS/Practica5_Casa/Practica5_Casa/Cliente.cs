using System;

public class Cliente
{
	string nombre;
	string apellido;
	string provincia;
	public Cliente(string nom, string ape, string pro)
	{
		nombre = nom;
		apellido = ape;
		provincia = pro;

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

	public string infoLb()
    {
		return nombre + " " + apellido + " " + provincia;
    }
	public string clienteEnFicheroProvincia()
    {
		return nombre + " " + apellido;

	}
    public string clienteEnFichero()
	{ 
		return nombre + "#" + apellido + "#" + provincia;
	}
}
