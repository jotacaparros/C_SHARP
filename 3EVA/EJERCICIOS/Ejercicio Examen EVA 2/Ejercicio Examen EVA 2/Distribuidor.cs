using System;

public class Distribuidor : Registro
{
	private string identificador;
	public Distribuidor(string nom, string ape, int tlf, string mail, string dir, string prov, string id )
	{
		_nombre = nom;
		_apellido = ape;
		_telefono = tlf;
		_email = mail;
		_direccion = dir;
		_provincia = prov;
		identificador = id;
	}
	public Distribuidor(string nom, string ape, int tlf, int tlf2, string mail, string dir, string prov, string id)
	{
		_nombre = nom;
		_apellido = ape;
		_telefono = tlf;
		_telefono2 = tlf2;
		_email = mail;
		_direccion = dir;
		_provincia = prov;
		identificador = id;
	}
}
