using System;
/*(6.4.3) Amplía el proyecto del ejercicio 6.3.3 (Libro): crea una clase "Documento",
de la que Libro heredará todos sus atributos y métodos. Ahora la clase Libro contendrá sólo un atributo
"paginas", número entero, con sus correspondientes Get y Set.*/

public class ResultadoDocumento
{
	string autor;
	string titulo;
	string ubicacion;

	public void SetAutor(string aut)
	{
		autor = aut;
	}

	public void SetTitulo(string tit)
	{
		titulo = tit;
	}

	public void SetUbicacion(string ubi)
	{
		ubicacion = ubi;
	}

	public string GetAutor()
	{
		return autor;
	}
	public string GetTitulo()
	{
		return titulo;
	}
	public string GetUbicacion()
	{
		return ubicacion;
	}
}
