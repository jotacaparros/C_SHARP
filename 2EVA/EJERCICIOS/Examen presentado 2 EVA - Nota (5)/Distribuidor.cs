using System;

public class Distribuidor
{
	string nombre;
	string apellido;
	int telefono1;
	int telefono2;
	string correo;
	string direccion;
	string provincia;
	string codigo;

	String[] provinciasDistribuidor = new String[7];

	public Distribuidor()
	{

	}
	/* - - - - - - - - - - - - - - - - - GETTERS  - - - - - - - - - - - - - - - - - */
	public string GetNombreDistribuidor()
	{
		return nombre;
	}

	public string GetApellidoDistribuidor()
	{
		return apellido;
	}

	public int GetTelefono1Distribuidor()
	{
		return telefono1;
	}

	public int GetTelefono2Distribuidor()
	{
		return telefono2;
	}

	public string GetCorreoDistribuidor()
	{
		return correo;
	}

	public string GetDireccionDistribuidor()
	{
		return direccion;
	}

	public string GetProvinciaDistribuidor()
	{
		return provincia;
	}

	/* - - - - - - - - - - - - - - - - - SETTERS  - - - - - - - - - - - - - - - - - */

	public void SetNombreDistribuidor(string nombreDistribuidor)
	{
		nombre = nombreDistribuidor;
	}

	public void SetApellidoDistribuidor(string apellidoDistribuidor)
	{
		apellido = apellidoDistribuidor;
	}

	public void SetTelefono1Distribuidor(int telefono1Distribuidor)
	{
		telefono1 = telefono1Distribuidor;
	}

	public void SetTelefono2Distribuidor(int telefono2Distribuidor)
	{
		telefono2 = telefono2Distribuidor;
	}

	public void SetCorreoDistribuidor(string correoDistribuidor)
	{
		correo = correoDistribuidor;
	}

	public void SetDireccionDistribuidor(string direccionDistribuidor)
	{
		direccion = direccionDistribuidor;
	}

	public void SetProvinciaDistribuidor(string provinciaDistribuidor)
	{
		provincia = provinciaDistribuidor;
	}
}

