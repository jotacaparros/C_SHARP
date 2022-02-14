using System;
/*(6.2.3) Para guardar información sobre libros, vamos a comenzar por crear una clase "Libro", 
que contendrá atributos "autor", "titulo", "ubicacion" (todos ellos strings) y métodos Get y Set
adecuados para leer su valor y cambiarlo. Prepara también un Main (en la misma clase), que cree un 
objeto de la clase Libro, dé valores a sus tres atributos y luego los muestre.*/
public class LibroResuelto2
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
