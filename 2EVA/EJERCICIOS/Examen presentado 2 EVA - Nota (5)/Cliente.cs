using System;

public class Cliente
{
	string nombre;
	string apellido;
	int telefono1;
	int telefono2;
	string correo;
	string direccion;
	string provincia;
	string codigo;

	String[] provinciasCliente = new String[3];

	public Cliente()
	{
	}
	/* - - - - - - - - - - - - - - - - - GETTERS  - - - - - - - - - - - - - - - - - */
	public string GetNombreCliente()
	{
		return nombre;
	}

	public string GetApellidoCliente()
	{
		return apellido;
	}

	public int GetTelefono1Cliente()
	{
		return telefono1;
	}

	public int GetTelefono2Cliente()
	{
		return telefono2;
	}

	public string GetCorreoCliente()
	{
		return correo;
	}

	public string GetDireccionCliente()
	{
		return direccion;
	}

	public string GetProvinciaCliente()
	{
		return provincia;
	}

	/* - - - - - - - - - - - - - - - - - SETTERS  - - - - - - - - - - - - - - - - - */

	public void SetNombreCliente(string nombreCliente)
	{
		nombre = nombreCliente;
	}

	public void SetApellidoCliente(string apellidoCliente)
	{
		apellido = apellidoCliente;
	}

	public void SetTelefono1Cliente(int telefono1Cliente)
	{
		telefono1 = telefono1Cliente;
	}

	public void SetTelefono2Cliente(int telefono2Cliente)
	{
		telefono2 = telefono2Cliente;
	}

	public void SetCorreoCliente(string correoCliente)
	{
		correo = correoCliente;
	}

	public void SetDireccionCliente(string direccionCliente)
	{
		direccion = direccionCliente;
	}

	public void SetProvinciaCliente(string provinciaCliente)
	{
		provincia = provinciaCliente;
	}

	public void SetCodigoCliente(string codigoCliente)
    {
		codigo = codigoCliente;
    }

    public override string ToString()
    {
		return $"Nombre: {nombre} Apellido: {apellido} Teléfono: {telefono1}";
    }
}
