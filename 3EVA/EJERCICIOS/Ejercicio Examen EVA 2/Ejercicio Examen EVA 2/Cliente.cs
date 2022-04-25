using System;

public class Cliente : Registro
{
	private short codigo;
	public Cliente(string nom, string ape, int tlf, string mail, string dir, string prov, short id)
	{
		_nombre = nom;
		_apellido = ape;
		_telefono = tlf;
		_email = mail;
		_direccion = dir;
		_provincia = prov;
		codigo = id;
	}
	public Cliente(string nom, string ape, int tlf, int tlf2, string mail, string dir, string prov, short id)
	{
		_nombre = nom;
		_apellido = ape;
		_telefono = tlf;
		_telefono2 = tlf2;
		_email = mail;
		_direccion = dir;
		_provincia = prov;
		codigo = id;
	}
}
